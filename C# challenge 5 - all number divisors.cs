using System.Linq;
public class Kata
{
  public static int[] Divisors(int num)
  {
    int[] a = Enumerable.Range(2, num / 2 + 1).ToArray();
    return a.Where(n => num % n == 0).ToArray();
  }
}