using System;
using System.Reflection.Metadata;
public class LuckyNumber
{
  static bool IsPrime(int n)
  {
    if(n<=1)return false;
    for(int i = 2; i * i <= n; i++)
    {
      if(n%i==0)
        return false;
    }
    return true;
  }
  static int DigitSum(int n)
  {
    int sum=0;
    while (n > 0)
    {
      sum+=n%10;
      n/=10;
    }
    return sum;
  }
  static bool IsLucky(int n)
  {
    if (IsPrime(n)) return false;
    int s1 = DigitSum(n);
    int s2 = DigitSum(n*n);
    return s2==s1*s1;
  }
  static int CountLucky(int m,int n)
  {
    int  count=0;
    for(int i = m; i <= n; i++)
    {
      if(IsLucky(i))
        count+=1;
    }
    return count;
  }
  public static void Main()
  {
    int m=20,n=30;
    int count=CountLucky(m,n);
    System.Console.WriteLine(count);
  }
}