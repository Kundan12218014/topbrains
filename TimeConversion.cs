using System;
using System.Text;
public class TimeConversion
{
  public static void Main()
  {
    int.TryParse(Console.ReadLine(),out int time);
    StringBuilder timeStr=new StringBuilder();
    int hour= (time / 60);
    int minutes=(time%60);
    timeStr.Append(hour.ToString().PadLeft(2,'0'));
    timeStr.Append(':');
    timeStr.Append(minutes.ToString().PadLeft(2,'0'));
    System.Console.WriteLine(timeStr);
  }
}