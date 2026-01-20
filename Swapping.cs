using System;
using System.Collections.Generic;
public class Swapping
{
  public static void SwapByRef(ref int a, ref int  b)
  {
    a=a^b;
    b=a^b;
    a=a^b;
  }
  public static void SwapByOut(int x,int y,out int n, out int  m)
  {
   n=x;
   m=y;
  }

  public static void Main()
  {
    int a=10,b=20;
    int x=10,y=20;
    System.Console.WriteLine($"a: {a},b: {b}");
    SwapByRef(ref a,ref b);
    System.Console.WriteLine($"a: {a},b: {b}");
    System.Console.WriteLine($"x: {x},y: {y}");
    SwapByOut(x,y,out int n,out int m);
    System.Console.WriteLine($"x: {m},y: {n}");

  }
}