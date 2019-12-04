using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    string[] num = numbers.Split(' ').OrderBy(c => int.Parse(c)).ToArray();
    return $"{num.Last()} {num.First()}";
    //var nums = numbers.Split(' ').Select(Int32.Parse).ToArray();
    //return $"{nums.Max()} {nums.Min()}";
  }
}