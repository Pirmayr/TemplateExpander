using System.Collections.Generic;

namespace TemplateExpander
{
  public class StringsStack : Stack<Strings>
  {
    public Strings GetActiveValues()
    {
      Strings result = new Strings();
      foreach (Strings currentStrings in this)
      {
        foreach (KeyValuePair<string, string> currentItem in currentStrings)
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