using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Please enter a number");
        // int numerator = int.Parse(Console.ReadLine());

        // Console.WriteLine("Please enter another number");
        // int denominator = int.Parse(Console.ReadLine());


        Fraction fraction1 = new Fraction();
        Console.WriteLine(); // Add blank space
        Console.WriteLine(fraction1.GetString());
        Console.WriteLine(fraction1.GetDecimal());
        Console.WriteLine("--------");


        Fraction fraction2 = new Fraction(3);
        Console.WriteLine(fraction2.GetString());
        Console.WriteLine(fraction2.GetDecimal());
        Console.WriteLine("--------");
        Console.WriteLine(); // Add blank space




        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetString());
        Console.WriteLine(fraction3.GetDecimal());
        Console.WriteLine("--------");
        Console.WriteLine(); // Add blank space



    }
}