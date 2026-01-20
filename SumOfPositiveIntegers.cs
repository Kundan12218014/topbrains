using System;
using System.Runtime.InteropServices;
public class SumPositive
{
  public static int SumUntilZero(int[] num)
  {
    int sum = 0;
    foreach (var it in num)
    {
      if (it < 0) continue;
      if (it == 0) break;
      sum += it;
    }
    return sum;
  }
  public static void Main()
  {
    int[] num = { 1, 2, 3, 4, 5, -2, 4, -1, 0 };
    System.Console.WriteLine(SumUntilZero(num));
  }
}