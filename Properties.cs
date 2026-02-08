/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
    private string _name;
    public string Name
    {
        get
        {
            return _name.ToUpper();
        }
        set
        {
            if (value != null)
            {
                _name = value;
            }
        }
    }
    private int _age;
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be negative");
            }
            _age = value;
        }
    }
    static void Main()
    {
        Console.WriteLine("Hello World");
        HelloWorld e = new HelloWorld();
        e.Name = "kundna";
        try
        {
            Console.WriteLine(e.Name);
            e.Age = 10;
            Console.WriteLine(e.Age);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}