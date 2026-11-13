public class Kata
{
    public static int Find(int[] integers)
    {
      int oddCount=0;
      int evenCount=0;
      foreach(int n in integers)
      {
        if(n%2==0)
          evenCount++;
        else
          oddCount++;
      }
       if (evenCount == 1)
       {
         foreach (int n in integers)
           if (n % 2 == 0) return n;
       }
      else
      {
        foreach (int n in integers)
          if (n % 2 != 0) return n;
      }
      return 0;
    }
}