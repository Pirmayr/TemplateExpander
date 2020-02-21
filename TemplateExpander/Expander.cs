using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace TemplateExpander
{
    internal static class Expander
    {
        private const string DefaultFilter = ".";

        /// <summary>The delimiter for variables in templates.</summary>
        private const string DelimiterVariable = "%";

        private const string ExtensionTemplate = ".txt";
        private const string NameAlias = "alias";
        private const string NameFilter = "filter";
        private const string NameReplacement = "replacement";
        private const char SeparatorFormat = ':';
        private const string ValueName = "#text";
        private const string VariableNameValue = DelimiterVariable + "value" + DelimiterVariable;

        public static string Expansion(string format, string templatesDirectory, XmlNode root, Parameters parameters)
        {
            return CleanValue(Expansion(format, root, parameters, ReadTemplates(templatesDirectory), new StringsStack()), false).Replace("~", " ");
        }

        /// <summary>Checks, if the node is accepted for processing.</summary>
        /// <param name="node">Node</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>true if the node ist accepted; otherwise, false.</returns>
        private static bool Accept(XmlNode node, Parameters parameters)
        {
            foreach (var currentFilterValue in parameters.GetValues(NameFilter, node.LocalName, DefaultFilter))
            {
                if (node.SelectSingleNode(currentFilterValue) != null)
                {
                    return true;
                }
            }
            return false;
        }

        private static void AddExpansion(Strings expansions, string key, string value, Parameters parameters)
        {
            var actualValue = value;
            actualValue = parameters.Get(NameReplacement).Aggregate(actualValue, (current, currentReplacement) => ReplaceWord(current, currentReplacement.Key, currentReplacement.Value));
            actualValue = parameters.Get(NameAlias).Aggregate(actualValue, (current, currentAlias) => currentAlias.Key == value ? currentAlias.Value : current);
            actualValue = RemoveVariables(actualValue);
            expansions.Append(key, actualValue);
            for (var i = 0; i < 10; ++i)
            {
                var currentKey = DelimiterVariable + key.Trim('%') + i + DelimiterVariable;
                if (!expansions.ContainsKey(currentKey))
                {
                    expansions.Add(currentKey, actualValue);
                    break;
                }
            }
        }

        private static void AddExpansions(string format, IEnumerable nodes, bool isValueTemplate, bool prefixVariable, Strings expansions, Parameters parameters, Strings templates, StringsStack stringsStack)
        {
            if (nodes != null)
            {
                foreach (XmlNode currentChild in nodes)
                {
                    AddExpansion(expansions, isValueTemplate ? VariableNameValue : DelimiterVariable + (prefixVariable ? format + SeparatorFormat : "") + currentChild.LocalName + DelimiterVariable, Expansion(format, currentChild, parameters, templates, stringsStack), parameters);
                }
            }
        }

        /// <summary>Cleans string.</summary>
        /// <param name="value">String to be cleaned.</param>
        /// <param name="removeCarriageReturn">Should carriage-returns be removed by replacing them with blanks?</param>
        /// <returns>Cleaned string.</returns>
        private static string CleanValue(string value, bool removeCarriageReturn)
        {
            var result = value;
            result = result.Trim();
            result = result.Replace("\r", "\n");
            result = removeCarriageReturn ? result.Replace("\n", " ") : ReplaceExhaustive(result, "\n\n\n", "\n\n");
            result = ReplaceExhaustive(result, "  ", " ");
            return result;
        }

        private static string Expansion(string format, XmlNode node, Parameters parameters, Strings templates, StringsStack expansionsStack)
        {
            var name = node.LocalName;
            if (name != ValueName)
            {
                if (Accept(node, parameters))
                {
                    var template = GetTemplate(format, name, templates);
                    var isValueTemplate = template.Contains(VariableNameValue);
                    var expansions = new Strings {{VariableNameValue, ""}};
                    expansionsStack.Push(expansions);
                    AddExpansions(format, node.ChildNodes, isValueTemplate, false, expansions, parameters, templates, expansionsStack);
                    AddExpansions(format, node.Attributes, false, false, expansions, parameters, templates, expansionsStack);
                    foreach (var currentFormat in GetFormats(GetVariables(template)))
                    {
                        AddExpansions(currentFormat, node.ChildNodes, isValueTemplate, true, expansions, parameters, templates, expansionsStack);
                        AddExpansions(currentFormat, node.Attributes, false, true, expansions, parameters, templates, expansionsStack);
                    }
                    var result = expansionsStack.GetActiveValues().Aggregate(template, (current, currentExpansion) => current.Replace(currentExpansion.Key, currentExpansion.Value));
                    expansionsStack.Pop();
                    return result;
                }
                return "";
            }
            return CleanValue(node.Value, true);
        }

        /// <summary>Gets the requested formats from the given variables.</summary>
        /// <param name="variables">Variables</param>
        /// <returns>The requested formats.</returns>
        /// <remarks>Example: In *mdtoc:heading* the format *mdtoc* is requested for the variable *heading*.</remarks>
        private static HashSet<string> GetFormats(HashSet<string> variables)
        {
            var result = new HashSet<string>();
            foreach (var currentVariable in variables)
            {
                var currentItems = currentVariable.Split(SeparatorFormat);
                if (currentItems.Length == 2)
                {
                    result.Add(currentItems[0]);
                }
            }
            return result;
        }

        private static string GetTemplate(string templateSet, string tag, Strings templates)
        {
            return templates.TryGetValue(templateSet + "." + tag, out var result) ? result : VariableNameValue;
        }

        private static HashSet<string> GetVariables(string text)
        {
            var result = new HashSet<string>();
            var inVariable = false;
            var currentVariable = "";
            foreach (var currentCharacter in text)
            {
                if (currentCharacter.ToString() == DelimiterVariable)
                {
                    if (inVariable)
                    {
                        result.Add(currentVariable);
                        currentVariable = "";
                    }
                    inVariable = !inVariable;
                }
                else if (inVariable)
                {
                    currentVariable += currentCharacter;
                }
            }
            return result;
        }

        /// <summary>Reads all template-files in a directory.</summary>
        /// <param name="templatesDirectory">Directory with template-files.</param>
        /// <returns>A dictionary with the templates read.</returns>
        /// <remarks>The keys of the dictionary are the filenames (without extension) of the template-files. The keys in turn are the names of nodes or attributes in the XML-file.</remarks>
        private static Strings ReadTemplates(string templatesDirectory)
        {
            var result = new Strings();
            foreach (var currentPath in Directory.GetFiles(templatesDirectory, "*" + ExtensionTemplate))
            {
                result.Add(Path.GetFileNameWithoutExtension(currentPath), File.ReadAllText(currentPath).Replace("\r", ""));
            }
            return result;
        }

        /// <summary>
        /// Removes unused variables from the given text.
        /// </summary>
        /// <remarks>This is a remark.</remarks>
        private static string RemoveVariables(string text)
        {
            var builder = new StringBuilder();
            var inVariable = false;
            foreach (var currentCharacter in text)
            {
                if (currentCharacter.ToString() == DelimiterVariable)
                {
                    inVariable = !inVariable;
                }
                else if (!inVariable)
                {
                    builder.Append(currentCharacter);
                }
            }
            return builder.ToString();
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

        /// <summary>Replaces word in text.</summary>
        /// <param name="text">Text</param>
        /// <param name="word">Word</param>
        /// <param name="replacement">Replacement</param>
        /// <param name="options">Options</param>
        /// <returns>String with word replaced.</returns>
        private static string ReplaceWord(this string text, string word, string replacement, RegexOptions options = RegexOptions.None)
        {
            return Regex.Replace(text, $@"\b{word}\b", replacement, options);
        }
    }
}