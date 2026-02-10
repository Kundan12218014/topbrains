using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
public class Program
{
  public static void Main()
  {
    // string s = "heelo";
    // s += " World";
    // System.Console.WriteLine(s);
    // String b="heelo";
    // System.Console.WriteLine(s==b);
    // string s1="hello";
    // string s2=new string(new char[]{'h','i'});
    // string s3=String.Copy(s1);
    // System.Console.WriteLine(s3);
    // string s1="test";
    // string s2=s1.Replace("t","b");
    // string s3=s1.Replace("l","k");
    // // System.Console.WriteLine(s3);

    // StringBuilder sb=new StringBuilder(50);
    // sb.Append("ananad");
    // sb.AppendLine("is good guy");
    // sb.Append("This is the best guy");
    // System.Console.WriteLine(sb.ToString()+sb.Length+" "+sb.Capacity);
    
    // StringBuilder sb2=new StringBuilder();

    // string a="this";
    // string b=new String(a.ToCharArray());
    // Console.WriteLine(Equals(a,b.ToUpper()));
    // Console.WriteLine(a==b);
    // System.Console.WriteLine(ReferenceEquals(a,b));
    // Console.WriteLine(string.Equals(a,b,StringComparison.OrdinalIgnoreCase));

    // string em=" ";
    // for(int i = 0; i < 5; i++)
    // {
    //   em+=i;
    // }
    // System.Console.WriteLine(em);
    // System.Console.WriteLine(em.Trim());

    // string seperated="A,B,C";
    // string []words= seperated.Split(',');
    // // System.Console.WriteLine(string.Join("-> ",words));

    // string token="A,B,,C";
    // string []words=token.Split(',');
    // System.Console.WriteLine(string.Join("->",words));

    // string tokens="a,,b;c|d  ";
    // // string []parts=tokens.Split(new char[]{',',';','|'},StringSplitOptions.RemoveEmptyEntries);
    // string []parts=tokens.Split(',').Select(x=>x.Trim()).ToArray();
    // System.Console.WriteLine(string.Join("->",parts));

    string text = "A, B, F;h, C ";

    string[] parts = text
        .Split(',',';')
        .Select(x => x.Trim())
        .ToArray();

    System.Console.WriteLine(string.Join("->", parts));

  }
}