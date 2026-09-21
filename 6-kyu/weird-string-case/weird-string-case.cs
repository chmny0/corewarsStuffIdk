using System;
using System.Linq;
​
public class Kata
{
  public static string ToWeirdCase(string s)
  {
    string[] words = s.Split(' ');
    string res = "";
    foreach(string word in words)
    {
      string result = "";
      for(int i = 0; i < word.Length; i++)
      {
        char c = word[i];
        if (i % 2 == 0)
          result += char.ToUpper(c);
        else
          result += char.ToLower(c);
      }
      res += result + " ";
    }
    return res.Trim();
  }
}