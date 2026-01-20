using System;
public class DisplayHeight
{
  public static string GetCategory(int heightCm)
  {
    if(heightCm<150)return "Short";
    else if(heightCm>=150&&heightCm<180)return "Average";
   else if(heightCm>=180)return "Tall";
   return "Invalid Height";
  }
  public static void Main()
  {
    int.TryParse(Console.ReadLine(),out int heightCm);
    string Category=GetCategory(heightCm);
    System.Console.WriteLine(Category);

  }
}