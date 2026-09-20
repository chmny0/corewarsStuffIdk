using System;
using System.Text.RegularExpressions;
​
public static class Kata
{
  public static bool ValidPhoneNumber(string phoneNumber)
  {
    return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}$");
  }
}