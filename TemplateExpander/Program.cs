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
      string templateSet = arguments[0];
      string templatesDirectory = arguments[1];
      string xmlPath = arguments[2];
      string outputPath = arguments[3];
      string parametersPath = arguments[4];
      string outputDirectory = Path.GetDirectoryName(outputPath);
      if (outputDirectory != null)
      {
        Directory.CreateDirectory(outputDirectory);
      }
      File.WriteAllText(outputPath, Expander.Expansion(templateSet, templatesDirectory, ReadXml(xmlPath), parametersPath));
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