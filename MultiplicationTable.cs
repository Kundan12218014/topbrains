using System;
using System.Collections.Generic;
public class MultiplicationTable
{
  public static void Main()
  {
    int.TryParse(Console.ReadLine(), out int n);
    int.TryParse(Console.ReadLine(), out int Upto);
    List<int> table = new List<int>();
    for (int i = 1; i <= Upto; i++)
    {
      table.Add(i * n);
    }
    foreach (var i in table)
    {
      System.Console.Write(i + " ");
    }
  }
}