using System.Collections.Generic;
using System.Linq;
using System;
​
public class Kata
{
  public static string SpinWords(string sentence)
  {
    string[] words = sentence.Split(' ');
    string res = "";
    
    foreach (string word in words)
    {
        if (word.Length < 5)
            res += word + " ";
        else
            res += new string(word.Reverse().ToArray()) + " ";
    }
    return res.Trim();
  }
}