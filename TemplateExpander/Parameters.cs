using System.Collections.Generic;
using System.IO;

namespace TemplateExpander
{
    public class Parameters : Dictionary<string, Strings>
    {
        public const char SeparatorValues = '|';

        public static Parameters ReadParameters(string path)
        {
            var result = new Parameters();
            foreach (var currentLine in File.ReadAllLines(path))
            {
                var currentItems = currentLine.Split(';');
                if (currentItems.Length == 3)
                {
                    var currentName = currentItems[0];
                    var currentKey = currentItems[1];
                    var currentValue = currentItems[2];
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
    }
}