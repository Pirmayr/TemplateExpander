using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace TemplateExpander
{
    internal static class Expander
    {
        private const string DefaultFilter = ".";
        private const string ExtensionTemplate = ".txt";
        private const string NameAlias = "alias";
        private const string NameFilter = "filter";
        private const char SeparatorValues = '|';
        private const string ValueName = "#text";
        private const string VariableNameValue = "%value%";

        public static string Expansion(string templateSet, string templatesDirectory, XmlNode root, string parametersPath)
        {
            return CleanValue(Expansion(templateSet, templatesDirectory, root, ReadParameters(parametersPath)), false);
        }

        private static bool Accept(XmlNode node, Parameters parameters)
        {
            foreach (var currentFilterValue in parameters.Get(NameFilter, node.LocalName, DefaultFilter).Split(SeparatorValues))
            {
                if (node.SelectSingleNode(currentFilterValue) != null)
                {
                    return true;
                }
            }
            return false;
        }

        private static void AddExpansion(Dictionary<string, string> expansions, string key, string value, Parameters parameters)
        {
            var alias = value;
            foreach (var currentAlias in parameters.Get(NameAlias))
            {
                if (currentAlias.Key == value)
                {
                    alias = currentAlias.Value;
                }
            }
            if (!expansions.ContainsKey(key))
            {
                expansions.Add(key, "");
            }
            expansions[key] += alias;
        }

        private static void AddExpansions(string templateSet, string templatesDirectory, IEnumerable nodes, bool isValueTemplate, Strings expansions, Parameters parameters)
        {
            if (nodes != null)
            {
                foreach (XmlNode currentChild in nodes)
                {
                    AddExpansion(expansions, isValueTemplate ? VariableNameValue : "%" + currentChild.LocalName + "%", Expansion(templateSet, templatesDirectory, currentChild, parameters), parameters);
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

        private static string Expansion(string templateSet, string templatesDirectory, XmlNode node, Parameters parameters)
        {
            var name = node.LocalName;
            if (name != ValueName)
            {
                if (Accept(node, parameters))
                {
                    var template = Template(templateSet, templatesDirectory, name);
                    var isValueTemplate = template.Contains(VariableNameValue);
                    var expansions = new Strings {{VariableNameValue, ""}};
                    AddExpansions(templateSet, templatesDirectory, node.ChildNodes, isValueTemplate, expansions, parameters);
                    AddExpansions(templateSet, templatesDirectory, node.Attributes, false, expansions, parameters);
                    return expansions.Aggregate(template, (current, currentExpansion) => current.Replace(currentExpansion.Key, currentExpansion.Value));
                }
                return "";
            }
            return CleanValue(node.Value, true);
        }

        private static Parameters ReadParameters(string path)
        {
            var result = new Parameters();
            foreach (var currentLine in File.ReadAllLines(path))
            {
                var currentItems = currentLine.Split(';');
                if (currentItems.Length == 3)
                {
                    var currentName = currentItems[0];
                    var currentKey = currentItems[1];
                    var currentValue = currentItems[2];
                    if (!result.ContainsKey(currentName))
                    {
                        result.Add(currentName, new Strings());
                    }
                    if (!result[currentName].ContainsKey(currentKey))
                    {
                        result[currentName].Add(currentKey, "");
                    }
                    if (!string.IsNullOrEmpty(result[currentName][currentKey]))
                    {
                        result[currentName][currentKey] += SeparatorValues;
                    }
                    result[currentName][currentKey] += currentValue;
                }
            }
            return result;
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

        private class Parameters : Dictionary<string, Strings>
        {
            public string Get(string name, string key, string defaultValue)
            {
                if (TryGetValue(name, out var section))
                {
                    if (section.TryGetValue(key, out var result))
                    {
                        return result;
                    }
                }
                return defaultValue;
            }

            public Strings Get(string name)
            {
                return TryGetValue(name, out var result) ? result : new Strings();
            }
        }

        private class Strings : Dictionary<string, string>
        {
        }
    }
}