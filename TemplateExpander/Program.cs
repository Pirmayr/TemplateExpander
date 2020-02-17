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
      XmlNodeList selectedNodes = root.SelectNodes("/doxygenindex/compound");
      if (selectedNodes != null)
      {
        foreach (XmlNode currentNode in selectedNodes)
        {
          XmlAttribute currentRefId = currentNode.Attributes?["refid"];
          if (currentRefId != null)
          {
            string currentPath = Path.GetDirectoryName(xmlPath) + "/" + currentRefId.Value + ".xml";
            if (File.Exists(currentPath))
            {
              XmlDocument currentRoot = new XmlDocument();
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
        string[] targets = arguments[0].Split('|');
        string optionsDirectory = arguments[1];
        foreach (string currentTarget in targets)
        {
          string currentOptionsPath = optionsDirectory + currentTarget + ".txt";
          Parameters parameters = Parameters.ReadParameters(currentOptionsPath);
          string format = parameters.Get("option", "format", "");
          string templatesDirectory = optionsDirectory + parameters.Get("option", "templates-directory", "");
          string xmlPath = optionsDirectory + parameters.Get("option", "xml-path", "");
          string outputDirectory = optionsDirectory + parameters.Get("option", "output-directory", "");
          string preCommandPath = parameters.Get("option", "pre-command-path", "");
          string preCommandParameter0 = parameters.Get("option", "pre-command-parameter-0", "");
          string preCommandParameter1 = parameters.Get("option", "pre-command-parameter-1", "");
          string preCommandArguments = string.Format(parameters.Get("option", "pre-command-arguments", ""), preCommandParameter0, preCommandParameter1);
          string postCommandPath = parameters.Get("option", "post-command-path", "");
          string postCommandParameter0 = parameters.Get("option", "post-command-parameter-0", "");
          string postCommandParameter1 = parameters.Get("option", "post-command-parameter-1", "");
          string postCommandArguments = string.Format(parameters.Get("option", "post-command-arguments", ""), postCommandParameter0, postCommandParameter1);

          preCommandPath = File.Exists(optionsDirectory + preCommandPath)? optionsDirectory + preCommandPath : preCommandPath;
          postCommandPath = File.Exists(optionsDirectory + postCommandPath)? optionsDirectory + postCommandPath : postCommandPath;
          Directory.SetCurrentDirectory(optionsDirectory);
          Process.Start(preCommandPath, preCommandArguments)?.WaitForExit();
          string outputPath = outputDirectory + Path.GetFileNameWithoutExtension(currentTarget) + "." + format;
          File.WriteAllText(outputPath, Expander.Expansion(format, templatesDirectory, ReadXml(xmlPath), parameters));
          Directory.SetCurrentDirectory(optionsDirectory);
          Process.Start(postCommandPath, postCommandArguments)?.WaitForExit();
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
      XmlDocument root = new XmlDocument();
      root.LoadXml(File.ReadAllText(xmlPath));
      AddDoxygenCompounds(xmlPath, root);
      return root;
    }
  }
}