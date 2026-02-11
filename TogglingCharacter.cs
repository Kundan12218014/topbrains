using System;
using System.Text;

class HelloWorld
{
  static void Main()
  {
    string input = Console.ReadLine();
    StringBuilder sb = new StringBuilder();
    foreach (char ch in input)
    {
      if (char.IsUpper(ch))
      {
        sb.Append(char.ToLower(ch));
      }
      else if (char.IsLower(ch))
      {
        sb.Append(char.ToUpper(ch));
      }
      else
      {
        sb.Append(ch);
      }
    }
    Console.WriteLine(sb.ToString());
  }
}