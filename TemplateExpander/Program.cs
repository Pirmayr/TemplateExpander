using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Xsl;

namespace TemplateExpander
{
  internal static class Program
  {
    private static void AddDoxygenCompounds(string xmlPath, XmlDocument root)
    {
      /*
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
      */
    }

    private static void ExecuteProgram(string command, string arguments, string workingDirectory)
    {
      Directory.SetCurrentDirectory(workingDirectory);
      Process process = new Process();
      process.StartInfo.FileName = command;
      process.StartInfo.Arguments = arguments;
      process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.RedirectStandardOutput = true;
      process.OutputDataReceived += OnDataReceived;
      process.ErrorDataReceived += OnDataReceived;
      process.Start();
      process.BeginOutputReadLine();
      process.WaitForExit();
      process.WaitForExit();
      process.Close();
    }

    private static void Main(string[] arguments)
    {
      try
      {
        string[] targets = arguments[0].Split(';');
        string[] formats = arguments[1].Split(';');
        string optionsPath = arguments[2];
        string optionsDirectory = Path.GetDirectoryName(optionsPath) + "/";
        foreach (string currentTarget in targets)
        {
          foreach (string currentFormat in formats)
          {
            Parameters parameters = Parameters.ReadParameters(optionsPath, currentTarget, currentFormat);
            string templatesDirectory = optionsDirectory + parameters.Get("option", "templates-directory", "");
            string xmlPath = optionsDirectory + parameters.Get("option", "xml-path", "");
            string outputDirectory = optionsDirectory + parameters.Get("option", "output-directory", "");
            string preCommandPath = parameters.Get("option", "pre-command-path", "");
            string preCommandArguments = parameters.Get("option", "pre-command-arguments", "").Replace("%target%", currentTarget).Replace("%format%", currentFormat);
            string postCommandPath = parameters.Get("option", "post-command-path", "");
            string postCommandArguments = parameters.Get("option", "post-command-arguments", "").Replace("%target%", currentTarget).Replace("%format%", currentFormat);
            preCommandPath = File.Exists(optionsDirectory + preCommandPath) ? optionsDirectory + preCommandPath : preCommandPath;
            preCommandPath = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? preCommandPath : Path.ChangeExtension(preCommandPath, null);
            postCommandPath = File.Exists(optionsDirectory + postCommandPath) ? optionsDirectory + postCommandPath : postCommandPath;
            postCommandPath = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? postCommandPath : Path.ChangeExtension(postCommandPath, null);
            if (!string.IsNullOrEmpty(preCommandPath))
            {
              ExecuteProgram(preCommandPath, preCommandArguments, optionsDirectory);
            }
            string outputPath = outputDirectory + Path.GetFileNameWithoutExtension(currentTarget) + "." + currentFormat;
            File.WriteAllText(outputPath, Expander.Expansion(currentFormat, templatesDirectory, ReadXml(xmlPath), parameters));
            if (!string.IsNullOrEmpty(postCommandPath))
            {
              ExecuteProgram(postCommandPath, postCommandArguments, outputDirectory);
              ExecuteProgram(postCommandPath, postCommandArguments, outputDirectory);
            }
          }
        }
        Environment.Exit(0);
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        Environment.Exit(1);
      }
    }

    private static void OnDataReceived(object sender, DataReceivedEventArgs e)
    {
      Console.WriteLine(e.Data);
    }

    private static XmlDocument ReadXml(string xmlPath)
    {
      /*
      XmlDocument root = new XmlDocument();
      root.LoadXml(File.ReadAllText(xmlPath));
      AddDoxygenCompounds(xmlPath, root);
      return root;
      */

      var transformFromXml = new XslCompiledTransform();
      var xslSettings = new XsltSettings(true, true);
      transformFromXml.Load("xml/doxygen.xsl", xslSettings, new XmlUrlResolver());
      transformFromXml.Transform("xml/index.xml", xmlPath);

      XmlDocument root = new XmlDocument();
      root.LoadXml(File.ReadAllText(xmlPath));
      return root;

    }
  }
}