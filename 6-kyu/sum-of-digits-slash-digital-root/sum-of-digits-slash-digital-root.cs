public class Number
{
  public static int DigitalRoot(long n)
  {
    while (n >= 10)
    {
        string s = n.ToString();
        int sum = 0;
        foreach (char c in s)
            sum += c - '0';
        n = sum;
    }
    return (int)n;
  }
}