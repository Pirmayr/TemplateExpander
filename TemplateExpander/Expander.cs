using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;

namespace TemplateExpander
{
    internal class Expander
    {
        private const string ExtensionTemplate = ".txt";
        private const string ValueName = "#text";
        private const string VariableNameValue = "%value%";

        public static string Expansion(string templateSet, string templatesDirectory, string xmlPath)
        {
            var root = new XmlDocument();
            root.LoadXml(File.ReadAllText(xmlPath));

            /*
            var specification = Directory.GetFiles(Path.GetDirectoryName(xmlPath), "*.xml");

            foreach (var currentPath in specification)
            {
              if (!string.Equals(Path.GetFileName(currentPath), Path.GetFileName(xmlPath), StringComparison.CurrentCultureIgnoreCase))
              {
                var currentRoot = new XmlDocument();  
                currentRoot.LoadXml(File.ReadAllText(currentPath));
                if (currentRoot.DocumentElement != null)
                {
                  foreach (XmlNode node in currentRoot.DocumentElement.ChildNodes)
                  {
                    XmlNode imported = root.ImportNode(node, true);
                    root.DocumentElement?.AppendChild(imported);
                  }
                }
              }
            }
            */

            /*
            var compoundNodes = root.SelectNodes("/doxygenindex/compound");

            if (compoundNodes != null)
            {
              foreach (XmlNode currentNode in  compoundNodes)
              {
                XmlAttribute currentRefId = currentNode.Attributes?["refid"];
                if (currentRefId != null)
                {
                  string currentPath = Path.GetDirectoryName(xmlPath) + "\\" + currentRefId.Value + ".xml";
                  if (File.Exists(currentPath))
                  {
                    XmlDocument currentRoot = new XmlDocument();
                    currentRoot.LoadXml(File.ReadAllText(currentPath));
                    if (currentRoot.DocumentElement != null)
                    {
                      foreach (XmlNode node in currentRoot.DocumentElement.ChildNodes)
                      {
                        XmlNode imported = root.ImportNode(node, true);
                        root.DocumentElement?.AppendChild(imported);
                      }
                    }
                  }
                }
              }
            }
            */

            return CleanValue(Expansion(templateSet, templatesDirectory, root), false);
        }

        private static void AddExpansion(Dictionary<string, string> expansions, string key, string value)
        {
            if (!expansions.ContainsKey(key))
            {
                expansions.Add(key, "");
            }
            expansions[key] += value;
        }

        private static void AddExpansions(string templateSet, string templatesDirectory, IEnumerable nodes, bool isValueTemplate, Strings expansions)
        {
            if (nodes != null)
            {
                foreach (XmlNode currentChild in nodes)
                {
                    AddExpansion(expansions, isValueTemplate ? VariableNameValue : "%" + currentChild.LocalName + "%", Expansion(templateSet, templatesDirectory, currentChild));
                }
            }
        }

        private static string CleanValue(string value, bool removeCarriageReturn)
        {
            var result = value;
            result = result.Trim();
            result = result.Replace("\r", "\n");
            result = removeCarriageReturn ? result.Replace("\n", " ") : ReplaceExhaustive(result, "\n\n\n", "\n\n");
            result = ReplaceExhaustive(result, "  ", " ");
            return result;
        }

        private static string Expansion(string templateSet, string templatesDirectory, XmlNode node)
        {
            var name = node.LocalName;
            if (name != ValueName)
            {
                var template = Template(templateSet, templatesDirectory, name);
                var isValueTemplate = template.Contains(VariableNameValue);
                var expansions = new Strings {{VariableNameValue, ""}};
                AddExpansions(templateSet, templatesDirectory, node.ChildNodes, isValueTemplate, expansions);
                AddExpansions(templateSet, templatesDirectory, node.Attributes, isValueTemplate, expansions);
                return expansions.Aggregate(template, (current, currentExpansion) => current.Replace(currentExpansion.Key, currentExpansion.Value));
            }
            return CleanValue(node.Value, true);
        }

        private static string ReplaceExhaustive(string value, string searchString, string replacement)
        {
            var result = value;
            var previousLength = result.Length;
            while (true)
            {
                result = result.Replace(searchString, replacement);
                var currentLength = result.Length;
                if (currentLength >= previousLength)
                {
                    return result;
                }
                previousLength = currentLength;
            }
        }

        private static string Template(string templateSet, string templatesDirectory, string tag)
        {
            var path = templatesDirectory + templateSet + "." + tag + ExtensionTemplate;
            return File.Exists(path) ? File.ReadAllText(path) : VariableNameValue;
        }

        private class Strings : Dictionary<string, string>
        {
        }
    }
}