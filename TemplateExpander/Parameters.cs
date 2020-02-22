using System.Collections.Generic;
using System.IO;

namespace TemplateExpander
{
  public class Parameters : Dictionary<string, Strings>
  {
    private const char SeparatorValues = '|';

    public static Parameters ReadParameters(string path, string target, string format)
    {
      var result = new Parameters();
      foreach (var currentLine in File.ReadAllLines(path))
      {
        var currentItems = currentLine.Split(';');
        if (currentItems.Length == 5)
        {
          var currentTarget = currentItems[0];
          var currentFormat = currentItems[1];
          if (Accept(target, currentTarget, format, currentFormat))
          {
            var currentName = currentItems[2];
            var currentKey = currentItems[3];
            var currentValue = currentItems[4];
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

    public string Get(string name, string key, string defaultValue)
    {
      if (TryGetValue(name, out var section))
      {
        if (section.TryGetValue(key, out var result))
        {
          return result;
        }
      }
      return defaultValue;
    }

    public Strings Get(string name)
    {
      return TryGetValue(name, out var result) ? result : new Strings();
    }

    public string[] GetValues(string name, string key, string defaultValue)
    {
      return Get(name, key, defaultValue).Split(SeparatorValues);
    }

    private static bool Accept(string target, string currentTarget, string format, string currentFormat)
    {
      return (currentTarget == "*" || target == currentTarget) && (currentFormat == "*" || format == currentFormat);
    }
  }
}