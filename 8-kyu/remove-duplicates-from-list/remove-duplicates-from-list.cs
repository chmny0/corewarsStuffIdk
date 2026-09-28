using System;
using System.Collections.Generic;
using System.Linq;
​
namespace Solution
{
  public static class Program
  {
    public static int[] distinct(int[] a)
    {
      var result = new List<int>();
      foreach(var v in a)
      {
        if(!result.Contains(v))
          result.Add(v);
      }
      return result.ToArray();
    }
  }
}