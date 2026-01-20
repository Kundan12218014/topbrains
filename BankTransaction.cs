using System;
using System.Transactions;
public class BankTransaction
{
public static int GetFinalBalance(int intialBalance,int [] transaction)
  {
    int balance=intialBalance;
    foreach(var curr in transaction)
    {
      if (curr >= 0)
      {
        balance+=curr;
      }
      else if (curr + balance >=0)
      {
        balance+=curr;
      }
    }
    return balance;
  }
  public static void Main()
  {
    int intialBalance=100;
    int[]transaction={ 50, -30, -150, 20, -10 };

    System.Console.WriteLine("FinalBalance: "+GetFinalBalance(intialBalance,transaction));
    
  }
}