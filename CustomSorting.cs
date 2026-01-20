using System;
using System.Collections.Generic;
public class Students : IComparable<Students>
{
  public string Name { get; set; }
  public int Age { get; set; }
  public int Mark { get; set; }
  public int CompareTo(Students oth)
  {
    if (Mark != oth.Mark)
    {
      return oth.Mark - Mark;
    }
    return Age - oth.Age;
  }
  public override string ToString()
  {
    return $"Name: {Name},Age: {Age},Marks : {Mark}";
  }
}
public class CustomSorting
{
  public static void Main()
  {
    List<Students> students = new List<Students>()
    {
      new Students(){Name="Kundan Kumar",Age=22,Mark=92},
      new Students(){Name="gaurav Kumar",Age=26,Mark=90},
      new Students(){Name="shayam Kumar",Age=32,Mark=89},
      new Students(){Name="Ghansham Kumar",Age=21,Mark=92},
      new Students(){Name="gulsan Kumar",Age=22,Mark=42},
      new Students(){Name="galat Kumar",Age=29,Mark=93},
    };

    students.Sort();
    foreach (var student in students)
    {
      System.Console.WriteLine(student);
    }
    // List<Student> sorted = SortStudents(students);

  }
  // List<Student> SortStudents(List<Student> students)
  // {
  //   return students
  //       .OrderByDescending(s => s.Marks)   // highest marks first
  //       .ThenBy(s => s.Age)                // if marks equal, youngest first
  //       .ToList();
  // }

}