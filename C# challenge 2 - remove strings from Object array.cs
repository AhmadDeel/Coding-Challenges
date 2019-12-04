using System;
using System.Linq;
public static class Kata
{
  public static int DescendingOrder(int num)
  {
    return Convert.ToInt32(string.Join("", num.ToString().ToCharArray().OrderByDescending(c => c)));
  }
}
