using System;
public class MidPointRounding
{
  public static double GetCircleArea(double radius)
  {
    double area=Math.PI*radius*radius;
    return Math.Round(area,2,MidpointRounding.AwayFromZero);
  }
  public static void Main()
  {
    System.Console.WriteLine(GetCircleArea(2));
    System.Console.WriteLine(GetCircleArea(2.3));
    System.Console.WriteLine(GetCircleArea(0));
  }
}