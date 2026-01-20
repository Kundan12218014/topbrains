using System;
public class Parsing
{
  public static void Main()
  {
    string input=Console.ReadLine();
    string [] tokens=input.Split(' ');
   int sum=0;
    foreach(var token in tokens)
    {
      int.TryParse(token,out int val);
      sum+=val;
    }
    System.Console.WriteLine(sum);
  }
}