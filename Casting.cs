using System;
using System.Data;
public class Person
{//less derived type 
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual string Type
    {
        get { return "Person"; }
    }

    public virtual void getInfo()
    {
        Console.WriteLine(Id + " " + Name);
    }
}
public class Employee : Person
{//more derived type
    public string role { get; set; }
    public double salary { get; set; }
    public override string Type
    {
        get
        {
            return "Employee";
        }
    }
    private string _name; 

    public override string Name
    {
        get
        {
            return _name.ToUpper();
        }
        set
        {
            _name = value;
        }
    }
    public override void getInfo()
    {
        Console.WriteLine(Id + " " + Name + " " + role + " " + salary);
    }
}
class Program
{

    static void Main()
    {

        Person p = new Employee() { Id = 10, Name = "Kundan", role = "Founder & CEO", salary = 1000000000000 };
        Person personRef = p;//upcasting

        // Console.WriteLine(personRef.role);
        // Console.WriteLine(personRef.Name);
        // if(personRef is Employee empRef){
        //     Console.WriteLine(empRef.role);
        // }
        // Employee empref=personRef as Employee;
        // if(empref!=null){
        //     Console.WriteLine(empref.Salary);
        // }

        List<Person> person = new List<Person>(){
            new Person(){Name="Kundal",Id=11},
            new Employee(){Name="Emran",Id=12,role="HR",salary=123343}
        };

        foreach (Person per in person)
        {
            per.getInfo();
            Console.WriteLine(per.Type);
        }
        //         DataTable student=new DataTable("Students");
        //         student.Columns.Add("StudentId",typeof(int));
        //         student.Columns.Add("Name",typeof(string));
        //         student.Columns.Add("Age",typeof(int));

        //         student.PrimaryKey=new DataColumn[]{student.Columns["StudentId"]};

        //         student.Rows.Add(1,"Kundan",22);
        //         student.Rows.Add(2,"Rohit",20);

        //         foreach(DataRow row in student.Rows){
        //             Console.WriteLine($"{row["StudentId"]} {row["Name"]} {row["Age"]}");
        //         }


    }
}

