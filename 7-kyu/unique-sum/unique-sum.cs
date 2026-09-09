using System;
using System.Collections.Generic;
using System.Linq;
​
public static class Kata
{
  public static int? UniqueSum(List<int> lst)
  {
    if(lst.Count == 0 || lst == null) return null;
    int sum = 0;
    List<int> unique = new List<int>();
    foreach(int i in lst)
    {
      if(!unique.Contains(i))
      {
        unique.Add(i);
        sum+=i;
      }
    }
    return sum;
  }
}