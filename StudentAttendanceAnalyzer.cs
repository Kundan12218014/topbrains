using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    string input = Console.ReadLine();
    string[] parseData = input.Split(',');
    Dictionary<int, string> Attendance = new Dictionary<int, string>();
    foreach (string stud in parseData)
    {
      string[] value = stud.Split(':');
      if (value.Length >= 1)
      {
        int id = 0;
        if (!int.TryParse(value[0], out id)) continue;

        Attendance.Add(id, (value.Length > 1 && value[1].Equals("Present")) ? "Present" : string.IsNullOrEmpty(value[1]) ? "Not Marked" : "Absent");


      }
    }
    int TotalPresent = Attendance.Where(s => s.Value.Equals("Present")).Count();
    int TotalAbsent = Attendance.Where(s => s.Value.Equals("Absent")).Count();
    int NotMarked = Attendance.Where(s => s.Value.Equals("Not Marked")).Count();


    foreach (var item in Attendance)
    {
      System.Console.WriteLine(item.Key + "-> " + item.Value);
    }

    Console.WriteLine("TotalPresent:" +TotalPresent+" TotalAbsent: "+ TotalAbsent+" Not Marked: "+NotMarked);
  }
}
