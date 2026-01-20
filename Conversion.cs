using System;
public class Conversion
{
  public static double GetInch(double feet)
  {
    double inch=feet*30.48;
    return Math.Round(inch, 2, MidpointRounding.AwayFromZero);
  }
  public static void Main()
  {
    System.Console.WriteLine(GetInch(2));
    System.Console.WriteLine(GetInch(3));
    System.Console.WriteLine(GetInch(0));
  }
}