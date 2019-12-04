using System.Linq;
public class Kata
{
  public static int FindShort(string s)
  {
    return s.Split(' ').OrderBy(c => c.Length).ToArray()[0].Length;
    //return s.Split(' ').Min(s1 => s1.Length );
    //return s.Split(' ').OrderBy(i => i.Length).Select(i=>i.Length).First();
  }
}
