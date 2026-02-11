using System;
using System.Collections.Generic;
public class Bike
{
  public string Model { get; set; }
  public int PricePerDay { get; set; }
  public string Brand { get; set; }
}
public class BikeUtilty
{
  public void AddBikeDetails(string model, string brand, int pricePerDay)
  {
    Bike newBike = new Bike() { Model = model, Brand = brand, PricePerDay = pricePerDay };
    Program.bikeDetails.Add(Program.bikeDetails.Count + 1, newBike);
  }
  public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
  {

    SortedDictionary<string, List<Bike>> details = new SortedDictionary<string, List<Bike>>();
    foreach (var item in Program.bikeDetails.Values)
    {
      if (!details.ContainsKey(item.Brand))
      {
        details[item.Brand] = new List<Bike>();
      }
      details[item.Brand].Add(item);
    }
    return details;
  }
}
public class Program
{
  public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();
  public static void Main()
  {

    BikeUtilty bikeUtilty = new BikeUtilty();
    int option;
    do
    {
      System.Console.WriteLine("1. Add Bike Details");
      System.Console.WriteLine("2. Group Bikes By Brand");
      System.Console.WriteLine("3. Exit");
      System.Console.Write("Enter Your Choice ");
      int.TryParse(Console.ReadLine(), out option);
      switch (option)
      {
        case 1:

          Console.Write("\nEnter the model: ");
          string model = Console.ReadLine();
          Console.Write("\nEnter the brand: ");
          string brand = Console.ReadLine();
          Console.Write("\nEnter the price per day: ");
          int pricePerDay = Convert.ToInt32(Console.ReadLine());
          bikeUtilty.AddBikeDetails(model, brand, pricePerDay);
          System.Console.WriteLine();
          Console.WriteLine("Bike details added successfully");
          break;

        case 2:
          SortedDictionary<string, List<Bike>> bikeBrands = bikeUtilty.GroupBikesByBrand();
          foreach (var bikeGroup in bikeBrands)
          {
            foreach (var bike in bikeDetails.Values)
            {
              System.Console.WriteLine($"{bikeGroup.Key} {bike.Model}");
            }
          }

          break;
        case 3:
          System.Console.WriteLine("Exit");
          break;
      }
    } while (option != 3);
  }
}