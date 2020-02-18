using System.Collections.Generic;
using System.IO;

namespace TemplateExpander
{
  public class Parameters : Dictionary<string, Strings>
  {
    public const char SeparatorValues = '|';

    public static Parameters ReadParameters(string path, string target, string format)
    {
      Parameters result = new Parameters();
      foreach (string currentLine in File.ReadAllLines(path))
      {
        string[] currentItems = currentLine.Split(';');
        if (currentItems.Length == 5)
        {
          string currentTarget = currentItems[0];
          string currentFormat = currentItems[1];
          if (Accept(target, currentTarget, format, currentFormat))
          {
            string currentName = currentItems[2];
            string currentKey = currentItems[3];
            string currentValue = currentItems[4];
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
      }
      return result;
    }

    public static bool Accept(string target, string currentTarget, string format, string currentFormat)
    {
      return (currentTarget == "*" || target == currentTarget) && (currentFormat == "*" || format == currentFormat);
    }

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

    public string[] GetValues(string name, string key, string defaultValue)
    {
      return Get(name, key, defaultValue).Split(SeparatorValues);
    }
  }
}