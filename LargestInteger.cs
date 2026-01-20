using System;
public class LargestInteger
{
  public static int FindLargst(int a,int b,int c)=>(a>=b&&a>=c)?a:(b>=a&&b>=c)?b:c;
  public static void Main()
  {
    int.TryParse(Console.ReadLine(),out int a);
    int.TryParse(Console.ReadLine(),out int b);
    int.TryParse(Console.ReadLine(),out int c);
    int largest= FindLargst(a,b,c);
    System.Console.WriteLine(largest);
  }
}