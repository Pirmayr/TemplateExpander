using System;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace TemplateExpander
{
    internal static class Program
    {
        private static void AddDoxygenCompounds(string xmlPath, XmlDocument root)
        {
            var selectedNodes = root.SelectNodes("/doxygenindex/compound");
            if (selectedNodes != null)
            {
                foreach (XmlNode currentNode in selectedNodes)
                {
                    var currentRefId = currentNode.Attributes?["refid"];
                    if (currentRefId != null)
                    {
                        var currentPath = Path.GetDirectoryName(xmlPath) + "/" + currentRefId.Value + ".xml";
                        if (File.Exists(currentPath))
                        {
                            var currentRoot = new XmlDocument();
                            currentRoot.LoadXml(File.ReadAllText(currentPath));
                            if (currentRoot.DocumentElement != null)
                            {
                                foreach (XmlNode node in currentRoot.DocumentElement.ChildNodes)
                                {
                                    root.DocumentElement?.AppendChild(root.ImportNode(node, true));
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void Main(string[] arguments)
        {
            // try
            {
                var templateSet = arguments[0];
                var templatesDirectory = arguments[1];
                var xmlPath = arguments[2];
                var outputDirectory = arguments[3];
                var parametersPath = arguments[4];
                var commandPath = arguments[5];
                var commandArguments = arguments[6];
                Process.Start(commandPath, commandArguments)?.WaitForExit();
                foreach (var currentParametersPath in parametersPath.Split(';'))
                {
                    var outputPath = outputDirectory + Path.GetFileNameWithoutExtension(currentParametersPath) + "." + templateSet;
                    File.WriteAllText(outputPath, Expander.Expansion(templateSet, templatesDirectory, ReadXml(xmlPath), currentParametersPath));
                }
                Environment.Exit(0);
            }
            // catch (Exception exception)
            {
                // Console.WriteLine(exception.Message);
                Environment.Exit(1);
            }
        }

        private static XmlDocument ReadXml(string xmlPath)
        {
            var root = new XmlDocument();
            root.LoadXml(File.ReadAllText(xmlPath));
            AddDoxygenCompounds(xmlPath, root);
            return root;
        }
    }
}