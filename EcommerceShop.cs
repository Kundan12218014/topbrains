using System;
public class InsufficientWalletBalanceException : Exception
{
  public InsufficientWalletBalanceException(string message) : base(message){}
}
public class EcommerceShop
{
  public string UserName { get; set; }
  public double WalletBalance { get; set; }
  public double TotalPurchaseAmount { get; set; }

  public EcommerceShop(string username, double wallletBalance, double totalpurchaseAmount)
  {
    UserName = username;
    WalletBalance = wallletBalance;
    TotalPurchaseAmount = totalpurchaseAmount;
  }
  public EcommerceShop MakePayment(string name, double balance, double amount)
  {
    if (amount > balance)
    {
      throw new InsufficientWalletBalanceException("Insufficient Balance in your digital wallet");
    }
    return new EcommerceShop("happy", 34596, 234);
  }
}
public class Program
{
  public static void Main()
  {
    EcommerceShop order = new EcommerceShop("Groccery", 2000, 1243);
    try
    {
      var details = order.MakePayment("Grocery", 10, 1243);
      if (details != null)
      {
        System.Console.WriteLine("Sucessfull");
      }
    }
    catch (InsufficientWalletBalanceException ex)
    {
      System.Console.WriteLine(ex.Message);
    }


  }
}