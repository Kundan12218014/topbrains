using System;
class Jewellery
{
  public string Id { get; set; }
  public string Type { get; set; }
  public string Material { get; set; }
  public int Price { get; set; }

  public Jewellery(string id, string type, string material, int price)
  {
    Id = id;
    Type = type;
    Material = material;
    Price = price;
  }
}
class JewelleryUtility
{
  public void GetJewelleryDetails(Jewellery jewellery)
  {
    Console.WriteLine($"Details: {jewellery.Id} {jewellery.Type} {jewellery.Price}");
  }
  public void UpdateJewelleryDetails(Jewellery jewellery, int price)
  {
    jewellery.Price = price;
    Console.WriteLine($"Updated Price: {jewellery.Price}");
  }
}
public class Program
{
  static void Main()
  {
    string input = Console.ReadLine();
    string[] details = input.Split(' ');

    if (details.Length < 3) return;
    int.TryParse(details[2], out int price);

    Jewellery jewellery = new Jewellery(details[0], details[1], "Materials", price);

    JewelleryUtility utility = new JewelleryUtility();

    int choice;
    do
    {
      string[] choiceInput = Console.ReadLine().Split(' ');

      if (choiceInput.Length < 1) return;

      int.TryParse(choiceInput[0], out choice);
      
      switch (choice)
      {
        case 1:
          utility.GetJewelleryDetails(jewellery);
          break;
        case 2:
          if(choiceInput.Length<2){
            Console.WriteLine("input need two parameter");
            break;
          }
          int.TryParse(choiceInput[1], out int updatedPrice);
          utility.UpdateJewelleryDetails(jewellery, updatedPrice);
          break;
        case 3:
          Console.WriteLine("Thank You");
          break;
        default:
          Console.WriteLine("Invalid Input. Input correct chioce");
          break;
      }
    } while (choice != 3);
  }
}
