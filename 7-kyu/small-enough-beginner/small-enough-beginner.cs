public class Kata
{
  public static bool SmallEnough(int[] a, int limit)
  {
    foreach(int i in a)
    {
      if(i > limit)
        return false;
    }
    return true;
  }
}