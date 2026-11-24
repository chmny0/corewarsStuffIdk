using System;
​
public class SameNbDivisors {
    
    public static int CountPairsInt(int diff, long nMax) 
    {
        int CountDivisors(long n)
        {
            int count = 0;
            long limit = (long)Math.Sqrt(n);
            for (long d = 1; d <= limit; d++)
            {
                if (n % d == 0)
                {
                    count += (d * d == n) ? 1 : 2;
                }
            }
            return count;
        }
        
        int[] divs = new int[nMax];
        for (long i = 1; i < nMax; i++)
        {
            divs[i] = CountDivisors(i);
        }
        
        int res = 0;
        for (long prev = 1; prev < nMax - diff; prev++)
        {
            if (divs[prev] == divs[prev + diff])
                res++;
        }
        return res;
    }
}
​