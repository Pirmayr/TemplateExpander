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
                var targets = arguments[0].Split('|');
                var optionsDirectory = arguments[1];
                foreach (var currentTarget in targets)
                {
                    var currentOptionsPath = optionsDirectory + currentTarget + ".txt";
                    var parameters = Parameters.ReadParameters(currentOptionsPath);
                    var formats = parameters.GetValues("option", "format", "");
                    foreach (var currentFormat in formats)
                    {
                        var templatesDirectory = optionsDirectory + parameters.Get("option", "templates-directory", "");
                        var xmlPath = optionsDirectory + parameters.Get("option", "xml-path", "");
                        var outputDirectory = optionsDirectory + parameters.Get("option", "output-directory", "");
                        var preCommandPath = parameters.Get("option", "pre-command-path", "");
                        var preCommandParameter0 = parameters.Get("option", "pre-command-parameter-0", "");
                        var preCommandParameter1 = parameters.Get("option", "pre-command-parameter-1", "");
                        var preCommandArguments = string.Format(parameters.Get("option", "pre-command-arguments", ""), preCommandParameter0, preCommandParameter1);
                        var postCommandPath = parameters.Get("option", "post-command-path", "");
                        var postCommandParameter0 = parameters.Get("option", "post-command-parameter-0", "");
                        var postCommandParameter1 = parameters.Get("option", "post-command-parameter-1", "");
                        var postCommandArguments = string.Format(parameters.Get("option", "post-command-arguments", ""), postCommandParameter0, postCommandParameter1);
                        preCommandPath = File.Exists(optionsDirectory + preCommandPath) ? optionsDirectory + preCommandPath : preCommandPath;
                        postCommandPath = File.Exists(optionsDirectory + postCommandPath) ? optionsDirectory + postCommandPath : postCommandPath;
                        Directory.SetCurrentDirectory(optionsDirectory);
                        if (!string.IsNullOrEmpty(preCommandPath))
                        {
                            Directory.SetCurrentDirectory(optionsDirectory);
                            Process.Start(preCommandPath, preCommandArguments)?.WaitForExit();
                        }
                        var outputPath = outputDirectory + Path.GetFileNameWithoutExtension(currentTarget) + "." + currentFormat;
                        File.WriteAllText(outputPath, Expander.Expansion(currentFormat, templatesDirectory, ReadXml(xmlPath), parameters));
                        if (!string.IsNullOrEmpty(postCommandPath))
                        {
                            Directory.SetCurrentDirectory(optionsDirectory);
                            Process.Start(postCommandPath, postCommandArguments)?.WaitForExit();
                        }
                    }
                    Environment.Exit(0);
                }
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