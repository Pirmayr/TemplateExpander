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
    private const string DelimiterVariable = "%";
    private const string ExtensionTemplate = ".txt";
    private const string NameAlias = "alias";
    private const string NameFilter = "filter";
    private const string NameReplacement = "replacement";
    private const char SeparatorFormat = ':';
    private const char SeparatorValues = '|';
    private const string ValueName = "#text";
    private const string VariableNameValue = DelimiterVariable + "value" + DelimiterVariable;
    
    private static StringsStack stringsStack = new StringsStack();

    public static string Expansion(string format, string templatesDirectory, XmlNode root, string parametersPath)
    {
      return CleanValue(Expansion(format, root, ReadParameters(parametersPath), ReadTemplates(templatesDirectory)), false);
    }

    /// <summary>Replaces word in text.</summary>
    /// <param name="text">Text</param>
    /// <param name="word">Word</param>
    /// <param name="replacement">Replacement</param>
    /// <param name="options">Options</param>
    /// <returns>String with word replaced.</returns>
    public static string ReplaceWord(this string text, string word, string replacement, RegexOptions options = RegexOptions.None)
    {
      return Regex.Replace(text, $@"\b{word}\b", replacement, options);
    }

    /// <summary>Checks, if the node is accepted for processing.</summary>
    /// <param name="node">Node</param>
    /// <param name="parameters">Parameters</param>
    /// <returns>"true" if the node ist accepted; otherwise, false.</returns>
    private static bool Accept(XmlNode node, Parameters parameters)
    {
      foreach (string currentFilterValue in parameters.Get(NameFilter, node.LocalName, DefaultFilter).Split(SeparatorValues))
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
      string actualValue = value;
      actualValue = parameters.Get(NameReplacement).Aggregate(actualValue, (current, currentReplacement) => ReplaceWord(current, currentReplacement.Key, currentReplacement.Value));
      actualValue = parameters.Get(NameAlias).Aggregate(actualValue, (current, currentAlias) => currentAlias.Key == value ? currentAlias.Value : current);
      expansions.Append(key, RemoveVariables(actualValue));
    }

    private static void AddExpansions(string format, IEnumerable nodes, bool isValueTemplate, bool prefixVariable, Strings expansions, Parameters parameters, Strings templates)
    {
      if (nodes != null)
      {
        foreach (XmlNode currentChild in nodes)
        {
          AddExpansion(expansions, isValueTemplate ? VariableNameValue : DelimiterVariable + (prefixVariable ? format + SeparatorFormat : "") + currentChild.LocalName + DelimiterVariable, Expansion(format, currentChild, parameters, templates), parameters);
        }
      }
    }

    /// <summary>Cleans string.</summary>
    /// <param name="Value">String to be cleaned.</param>
    /// <param name="removeCarriageReturn">Should carriage-returns be removed by replacing them with blanks?</param>
    /// <returns>Cleaned string.</returns>
    private static string CleanValue(string value, bool removeCarriageReturn)
    {
      string result = value;
      result = result.Trim();
      result = result.Replace("\r", "\n");
      result = removeCarriageReturn ? result.Replace("\n", " ") : ReplaceExhaustive(result, "\n\n\n", "\n\n");
      result = ReplaceExhaustive(result, "  ", " ");
      return result;
    }

    private static string Expansion(string format, XmlNode node, Parameters parameters, Strings templates)
    {
      string name = node.LocalName;
      if (name != ValueName)
      {
        if (Accept(node, parameters))
        {
          string template = GetTemplate(format, name, templates);
          bool isValueTemplate = template.Contains(VariableNameValue);
          var expansions = new Strings {{VariableNameValue, ""}};
          AddExpansions(format, node.ChildNodes, isValueTemplate, false, expansions, parameters, templates);
          AddExpansions(format, node.Attributes, false, false, expansions, parameters, templates);
          foreach (string currentFormat in GetFormats(GetVariables(template)))
          {
            AddExpansions(currentFormat, node.ChildNodes, isValueTemplate, true, expansions, parameters, templates);
            AddExpansions(currentFormat, node.Attributes, false, true, expansions, parameters, templates);
          }
          return expansions.Aggregate(template, (current, currentExpansion) => current.Replace(currentExpansion.Key, currentExpansion.Value));
        }
        return "";
      }
      return CleanValue(node.Value, true);
    }

    private static HashSet<string> GetFormats(HashSet<string> variables)
    {
      HashSet<string> result = new HashSet<string>();
      foreach (string currentVariable in variables)
      {
        string[] currentItems = currentVariable.Split(SeparatorFormat);
        if (currentItems.Length == 2)
        {
          result.Add(currentItems[0]);
        }
      }
      return result;
    }

    private static string GetTemplate(string templateSet, string tag, Strings templates)
    {
      return templates.TryGetValue(templateSet + "." + tag, out string result) ? result : VariableNameValue;
    }

    private static HashSet<string> GetVariables(string text)
    {
      HashSet<string> result = new HashSet<string>();
      bool inVariable = false;
      string currentVariable = "";
      foreach (char currentCharacter in text)
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

    private static Parameters ReadParameters(string path)
    {
      Parameters result = new Parameters();
      foreach (string currentLine in File.ReadAllLines(path))
      {
        string[] currentItems = currentLine.Split(';');
        if (currentItems.Length == 3)
        {
          string currentName = currentItems[0];
          string currentKey = currentItems[1];
          string currentValue = currentItems[2];
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

    private static Strings ReadTemplates(string templatesDirectory)
    {
      Strings result = new Strings();
      foreach (string currentPath in Directory.GetFiles(templatesDirectory, "*" + ExtensionTemplate))
      {
        result.Add(Path.GetFileNameWithoutExtension(currentPath), File.ReadAllText(currentPath).Replace("\r", ""));
      }
      return result;
    }

    private static string RemoveVariables(string text)
    {
      StringBuilder builder = new StringBuilder();
      bool inVariable = false;
      foreach (char currentCharacter in text)
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
      string result = value;
      int previousLength = result.Length;
      while (true)
      {
        result = result.Replace(searchString, replacement);
        int currentLength = result.Length;
        if (currentLength >= previousLength)
        {
          return result;
        }
        previousLength = currentLength;
      }
    }

    private class Parameters : Dictionary<string, Strings>
    {
      public string Get(string name, string key, string defaultValue)
      {
        if (TryGetValue(name, out Strings section))
        {
          if (section.TryGetValue(key, out string result))
          {
            return result;
          }
        }
        return defaultValue;
      }

      public Strings Get(string name)
      {
        return TryGetValue(name, out Strings result) ? result : new Strings();
      }
    }

    private class StringsStack : Stack<Strings>
    {
      
    }
    
    private class Strings : Dictionary<string, string>
    {
      public void Append(string key, string value)
      {
        if (!ContainsKey(key))
        {
          Add(key, "");
        }
        this[key] += value;
      }
    }
  }
}