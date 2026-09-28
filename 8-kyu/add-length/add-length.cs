using System.Linq;
using System;
​
public class Kata
{
  public static string[] AddLength(string str)
  {
    string[] words = str.Split(' ');
    string[] result = new string[words.Length];  // размер известен!
    
    for (int i = 0; i < words.Length; i++)
    {
        result[i] = words[i] + " " + words[i].Length;
    }
    
    return result;
  }
}