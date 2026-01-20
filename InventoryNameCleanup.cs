using System;
using System.Globalization;
using System.Text;
public class InventoryNameCleanup
{
  public static void Main()
  {
    string input= "llapppptop bag".Trim();
    StringBuilder result=new StringBuilder();
    char prev='\0';
    foreach(char ch in input)
    {
      if(prev!=ch){
        result.Append(ch);
      }
      prev=ch;
    }
    string titleCase=CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result.ToString().ToLower());
    System.Console.WriteLine(titleCase);
    
  }
}