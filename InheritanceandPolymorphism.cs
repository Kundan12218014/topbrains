using System;
using System.Globalization;
public abstract class Employee
{
  public abstract double GetPay();
}
class HourlyEmployee : Employee
{
  public double Rate { get; set; }  
  public double  Hours { get; set; }  
  public HourlyEmployee(double Hours,double Rate)
  {
    this.Rate=Rate;
    this.Hours=Hours;
  }
  public override double GetPay()
  {
    return Rate*Hours;
    throw new NotImplementedException();
  }
}
public class SalariedEmployee:Employee
{
  public double  MonthlySalary { get; set; }
  public SalariedEmployee(double MonthlySalary)
  {
    this.MonthlySalary=MonthlySalary;
  }
  public override double GetPay()
  {
    return MonthlySalary;
    throw new NotImplementedException();
  }
}
public class CommissionEmployee : Employee
{
  public double Commission { get; set; }
  public double  BaseSalary { get; set; }
  public CommissionEmployee(double Commission,double BaseSalary)
  {
    this.BaseSalary=BaseSalary;
    this.Commission=Commission;
  }
  public override double GetPay()
  {
    return BaseSalary+Commission;
    throw new NotImplementedException();
  }
}
public class InheritanceAndPolymorphism
{
  public static void Main()
  {
    string[] employees =
    {
      "H 50 8",
      "S 50000",
      "C 12000 30000"
    };
    double totalPay=ComputeTotalPay(employees);
    System.Console.WriteLine(totalPay.ToString("F2",CultureInfo.InvariantCulture));
  }
  public static double ComputeTotalPay(string[] employees)
  {
    double totalPay=0;
    if (employees == null || employees.Length == 0)
    {
      return totalPay;
    }
    foreach(string employee in employees)
    {
      string [] parts=employee.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      char type=parts[0][0];
      Employee emp=null;
      switch (type)
      {
        case 'H':
          double hours=double.Parse(parts[1], CultureInfo.InvariantCulture);
          double rate=double.Parse(parts[2],CultureInfo.InvariantCulture);
          emp=new HourlyEmployee(hours,rate);
          break;

        case 'S':
        double monthlySalary=double.Parse(parts[1], CultureInfo.InvariantCulture);
        emp=new SalariedEmployee(monthlySalary);
        break;
        case 'C':
        double commision=double.Parse(parts[1], CultureInfo.InvariantCulture);
        double baseSalary=double.Parse(parts[2], CultureInfo.InvariantCulture);
        emp=new CommissionEmployee(commision,baseSalary);
        break;

      }
      if(emp!=null)
      {
        totalPay+=emp.GetPay();
      }
    }
    return totalPay;

  }
}