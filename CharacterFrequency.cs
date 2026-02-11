using System;
using System.Collections.Generic;
using System.Globalization;
public class WordCount
{
  public static void Main()
  {
    // string s = "Kundan kumar kundan";
    // // TextInfo textInfo=CultureInfo.CurrentCulture.TextInfo;
    // // string result=textInfo.ToTitleCase(s);
    // // Console.WriteLine(result);
    // char []arr=s.ToCharArray();
    // arr[0]=char.ToUpper(arr[0]);

    // for(int i = 1; i < arr.Length; i++)
    // {
    //   if(arr[i-1]==' ')
    //   {
    //     arr[i]=char.ToUpper(arr[i]);
    //   }
    // }
    // Console.WriteLine(new String(arr));


    string []arr= s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    Array.Reverse(arr);
    Console.WriteLine(string.Join(" ",arr));


    // Dictionary<char, int> map = new Dictionary<char, int>();
    // foreach (char ch in s.ToLower())
    // {
    //   if (map.ContainsKey(ch))
    //   {
    //     map[ch]++;
    //   }
    //   else
    //   {
    //     map[ch] = 1;
    //   }
    // }
    // foreach (var val in map)
    // {
    //   System.Console.WriteLine($"{val.Key} {val.Value}");
    // }
  }
}