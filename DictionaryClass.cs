using System;
using System.Collections.Generic;
public class DictionaryClass
{
  public static int GetTotalSalay(List<int>ids,Dictionary<int,int>salaryList)
  {
    int total=0;
    foreach(int id in ids)
    {
      if(salaryList.ContainsKey(id))
        total+=salaryList[id];
    }
    return total;
  }
  public static void Main()
  {
    List<int>id=new List<int>()
    {
      1,4,5
    };
    Dictionary<int,int>salaryMap=new Dictionary<int, int>()
    {
      {1,20000},
      {4,40000},
      {5,15000}
    };
    Console.WriteLine(GetTotalSalay(id, salaryMap));

  }
}