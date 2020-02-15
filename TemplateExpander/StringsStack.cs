using System.Collections.Generic;

namespace TemplateExpander
{
    public class StringsStack : Stack<Strings>
    {
        public Strings GetActiveValues()
        {
            var result = new Strings();
            foreach (var currentStrings in this)
            {
                foreach (var currentItem in currentStrings)
                {
                    if (!result.ContainsKey(currentItem.Key))
                    {
                        result.Add(currentItem.Key, currentItem.Value);
                    }
                }
            }
            return result;
        }
    }
}