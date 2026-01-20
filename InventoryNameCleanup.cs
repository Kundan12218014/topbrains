using System;
using System.Globalization;
using System.Text;
public class InventoryNameCleanup
{
  public static void Main()
  {
    // string input= "llapppptop bag".Trim();
    // StringBuilder result=new StringBuilder();
    // char prev='\0';
    // foreach(char ch in input)
    // {
    //   if(prev!=ch){
    //     result.Append(ch);
    //   }
    //   prev=ch;
    // }
    // string titleCase=CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result.ToString().ToLower());
    // System.Console.WriteLine(titleCase);
    string inp=Console.ReadLine().Trim();
    StringBuilder res=new StringBuilder();
    bool isNewWord=true;
    foreach(char ch in inp)
    {
      if (ch==' ')
      {
        res.Append(ch);
        isNewWord=true;
      }
      else
      {
        if (isNewWord)
        {
          res.Append(char.ToUpper(ch));
          isNewWord=false;
        }
        else
        {
          res.Append(ch);
        }
      }
    }
System.Console.WriteLine(res.ToString());
    
  }
}