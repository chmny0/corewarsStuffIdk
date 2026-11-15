using System.Linq;
​
namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        foreach (var g in seq.GroupBy(x => x))
        {
          if (g.Count() % 2 != 0)
            return g.Key;
        }
      return 0;
    }
  }
}