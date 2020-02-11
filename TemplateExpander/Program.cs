using System.IO;

namespace TemplateExpander
{
    internal static class Program
    {
        private static void Main()
        {
            var expansion = Expander.Expansion("md", @"c:/usr/prg/TemplateExpander/TemplateExpander/Templates/", @"C:\Entwicklung\branches\B5010\P4\Source\chiemsee\Components\ObjectViewer\Doc\xml\all.xml");
            File.WriteAllText(@"c:/usr/prg/TemplateExpander/TemplateExpander/all.md", expansion);
        }
    }
}