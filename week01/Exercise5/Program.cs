using System;

class Program
{
    static void Main(string[] args)
    {

    // Welcome Message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

    // Prompts user name
        static string PromptUserName()
        {
            Console.WriteLine("Enter your Name. ");
            string userName = Console.ReadLine();
            return userName;
        }

    // Prompts favorite number
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

    // Squares a number
        static int SquareNumber(int favNum)
        {
            int square = favNum*favNum;
            return square;
        }

    // Displays results
        static void DisplayResults(string name, int favNum)
        {
            Console.WriteLine(""); // Use this to create whitespace
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your favorite Number is {favNum}");
            Console.WriteLine($"{name}, the square of your number is {SquareNumber(favNum)}");
        }

    // Main function
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int favNum = PromptUserNumber();
            SquareNumber(favNum);
            DisplayResults(name, favNum);
        }

        Main();
    }
}