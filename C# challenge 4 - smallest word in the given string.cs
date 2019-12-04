using System.Linq;
public class Kata
{
  public static int FindShort(string s)
  {
    return s.Split(new char[] { ' ' }).OrderBy(c => c.Length).ToArray()[0].Length;
  }
}