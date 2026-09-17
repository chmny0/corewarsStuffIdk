using System;
​
namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)  
    {
      if (string.IsNullOrWhiteSpace(str))
                return "";
​
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string result = "";
​
            foreach (string w in words)
            {
              result += w.Substring(0, 1).ToUpper() + w.Substring(1);
            }
​
            return result;
    }
  }
}
​
​