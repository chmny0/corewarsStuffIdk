using System.Linq;
namespace Solution
{
  public static class ArraysInversion
  {
    public static int[] InvertValues(int[] input)
    {
      int[] doaflip = new int[input.Length];
      for (int i = 0; i < input.Length; i++)
      {
        doaflip[i] = -input[i];
      }
      return doaflip;
    }
  }
}