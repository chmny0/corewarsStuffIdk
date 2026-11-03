using System.Linq;
​
public class Accumul 
{
  public static string Accum(string s) 
  {
    int num = 1;
    string res = "";
    
     foreach(char c in s)
     {
       string demo = new string(char.ToLower(c), num);
       string demo2 = demo[0].ToString().ToUpper() + demo.Substring(1);
       res += demo2 + "-";
       num++;
     }
    
    return res.TrimEnd('-');
  }
}