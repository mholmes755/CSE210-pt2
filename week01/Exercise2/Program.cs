using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        Console.WriteLine();
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        int secondDigit = percentage % 10;

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        string sign = "";
        if (secondDigit >= 7)
        {
            sign = "+";
        } 
        else if (secondDigit <= 3)
        {
            sign = "-";
        }


        Console.WriteLine($"Your grade is {letter}{sign}");
        if (percentage < 70)
        {
            Console.WriteLine("Regretably, you have failed the class.");
        }
        else 
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
    }
}