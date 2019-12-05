using System;
using System.Linq;

public static class Kata
{
  public static string Order(string words)
  {
     string[] wordList = words.Split(' ');
     Array.Sort(wordList, delegate (string m, string n)
      {
          string numbers = "123456789";
          int a = n
              .Where(c => numbers.IndexOf(c) > -1)
              .Select(c => int.Parse(c.ToString())).FirstOrDefault();
          int b = m
              .Where(c => numbers.IndexOf(c) > -1)
              .Select(c => int.Parse(c.ToString())).FirstOrDefault();
          return a > b ? -1 : a < b ? 1 : 0;
      });
      string res = string.Join(" ", wordList); 
      return res;
  }

  // if (string.IsNullOrEmpty(words)) return words;
  // return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));

  // return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));

  // var orderedWords = words.Split(" ").OrderBy(x => Regex.Match(x, @"\d").Value);
  // return string.Join(" ", orderedWords);
}

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return a + b > c ? (b + c > a ? (c + a > b ? true : false) : false) : false;
    }
}

public class NewKata
{
  public static string Rgb(int r, int g, int b) 
  {
  if (r > 255) r = 255;
  if (g > 255) g = 255;
  if (b > 255) b = 255;
  if (r < 0) r = 0;
  if (g < 0) g = 0;
  if (b < 0) b = 0;
  return r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

  // r = Math.Max(Math.Min(255, r), 0);
  // g = Math.Max(Math.Min(255, g), 0);
  // b = Math.Max(Math.Min(255, b), 0);
  // return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);

  // return Math.Clamp(r, 0, 255).ToString("X2") + Math.Clamp(g, 0, 255).ToString("X2") + Math.Clamp(b, 0, 255).ToString("X2");

  // Func<int, string> f = x => ((x < 16) ? "0" : "") + ((x > 255) ? 255 : (x < 0) ? 0 : x).ToString("X");
  // return f(r) + f(g) + f(b);
  }
}