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
    private static void ExecuteProgram(string command, string arguments, string workingDirectory)
    {
      Directory.SetCurrentDirectory(workingDirectory);
      var process = new Process
      {
        StartInfo =
        {
          FileName = command,
          Arguments = arguments,
          WindowStyle = ProcessWindowStyle.Hidden,
          UseShellExecute = false,
          RedirectStandardOutput = true
        }
      };
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
        var targets = arguments[0].Split(';');
        var formats = arguments[1].Split(';');
        var optionsPath = arguments[2];
        var optionsDirectory = Path.GetDirectoryName(optionsPath) + "/";
        foreach (var currentTarget in targets)
        {
          foreach (var currentFormat in formats)
          {
            var parameters = Parameters.ReadParameters(optionsPath, currentTarget, currentFormat);
            var templatesDirectory = optionsDirectory + parameters.Get("option", "templates-directory", "");
            var xslPath = optionsDirectory + parameters.Get("option", "xsl-path", "");
            var intermediateXmlPath = optionsDirectory + parameters.Get("option", "intermediate-xml-path", "");
            var xmlPath = optionsDirectory + parameters.Get("option", "xml-path", "");
            var outputDirectory = optionsDirectory + parameters.Get("option", "output-directory", "");
            var preCommandPath = parameters.Get("option", "pre-command-path", "");
            var preCommandArguments = parameters.Get("option", "pre-command-arguments", "").Replace("%target%", currentTarget).Replace("%format%", currentFormat);
            var postCommandPath = parameters.Get("option", "post-command-path", "");
            var postCommandArguments = parameters.Get("option", "post-command-arguments", "").Replace("%target%", currentTarget).Replace("%format%", currentFormat);
            preCommandPath = File.Exists(optionsDirectory + preCommandPath) ? optionsDirectory + preCommandPath : preCommandPath;
            preCommandPath = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? preCommandPath : Path.ChangeExtension(preCommandPath, null);
            postCommandPath = File.Exists(optionsDirectory + postCommandPath) ? optionsDirectory + postCommandPath : postCommandPath;
            postCommandPath = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? postCommandPath : Path.ChangeExtension(postCommandPath, null);
            if (!string.IsNullOrEmpty(preCommandPath))
            {
              ExecuteProgram(preCommandPath, preCommandArguments, optionsDirectory);
            }
            var outputPath = outputDirectory + Path.GetFileNameWithoutExtension(currentTarget) + "." + currentFormat;
            File.WriteAllText(outputPath, Expander.Expansion(currentFormat, templatesDirectory, ReadXml(xslPath, intermediateXmlPath, xmlPath), parameters));
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

    private static XmlDocument ReadXml(string xslPath, string intermediateXmlPath, string xmlPath)
    {
      var transformFromXml = new XslCompiledTransform();
      var xslSettings = new XsltSettings(true, true);
      transformFromXml.Load(xslPath, xslSettings, new XmlUrlResolver());
      transformFromXml.Transform(intermediateXmlPath, xmlPath);
      var root = new XmlDocument();
      root.LoadXml(File.ReadAllText(xmlPath));
      return root;
    }
  }
}