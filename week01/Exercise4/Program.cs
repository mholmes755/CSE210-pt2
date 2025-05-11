using System;

class Program
{
    static void Main(string[] args)
    {
        string another = "";
        var numbers = new List<int>();
        do
        {
            // I want to have the opening message display differently than the 
            // message to be displayed if they've already entered a number.
            if (numbers.Count < 1)
            {
                Console.WriteLine("Let's make a list of numbers! Please enter a numer: )");
            }
            else
            {
                Console.WriteLine("Please enter another number. ");
            }
            
            // Console.WriteLine always returns a string. This line makes it an int.
            int number = int.Parse(Console.ReadLine());

            // This line adds the entry from the user to the list "numbers"
            numbers.Add(number);
            Console.WriteLine("Do you want to enter another number? ");
            another = Console.ReadLine().ToLower();

        } while (another != "no");

        int sum = 0;
        int max = numbers[0];
        int min = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

            double avg = (double)sum/numbers.Count;

        Console.WriteLine($"You entered {numbers.Count} numbers!");
        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is {avg:F2}");
        Console.WriteLine($"The smallest number is {min}.");
        Console.WriteLine($"The largest number is {max}.");
        }
    }
