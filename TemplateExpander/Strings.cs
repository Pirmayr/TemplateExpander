using System.Collections.Generic;

namespace TemplateExpander
{
    public class Strings : Dictionary<string, string>
    {
        public void Append(string key, string value)
        {
            if (!ContainsKey(key))
            {
                Add(key, value);
            }
            this[key] += value;
        }
    }
}