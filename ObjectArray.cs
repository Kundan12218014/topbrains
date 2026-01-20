using System;
using Microsoft.Win32.SafeHandles;
public class ObjectClass
{
  public static int  SumOnlyIntegers(object[] arr)
  {
    int sum = 0;
    foreach (var v in arr)
    {
      if (v is int x)
      {
        sum += x;
      }
    }
    return sum;
  }
  public static void Main()
  {
    object[] arr = { "kundan", 10, null, true, -3, 2.3 };
    System.Console.WriteLine(SumOnlyIntegers(arr));
  }
}