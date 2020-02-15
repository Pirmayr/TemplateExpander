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
            try
            {
                var parametersPath = arguments[0];
                var parameters = Parameters.ReadParameters(parametersPath);
                var format = parameters.Get("option", "format", "");
                var templatesDirectory = parameters.Get("option", "templates-directory", "");
                var xmlPath = parameters.Get("option", "templates-directory", "");
                var outputDirectory = parameters.Get("option", "templates-directory", "");
                var preCommandPath = parameters.Get("option", "templates-directory", "");
                var preCommandArguments = parameters.Get("option", "templates-directory", "");
                var postCommandPath = parameters.Get("option", "templates-directory", "");
                var postCommandArguments = parameters.Get("option", "templates-directory", "");
                Process.Start(preCommandPath, preCommandArguments)?.WaitForExit();
                var outputPath = outputDirectory + Path.GetFileNameWithoutExtension(parametersPath) + "." + format;
                File.WriteAllText(outputPath, Expander.Expansion(format, templatesDirectory, ReadXml(xmlPath), parameters));
                Process.Start(postCommandPath, postCommandArguments)?.WaitForExit();
                Environment.Exit(0);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
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