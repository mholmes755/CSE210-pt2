using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string menuResponse;
        do 
        {
            // Needs a menu so users can select what activity to do
            Console.WriteLine("Please select an activity:");
            Console.WriteLine($"\n1. Breathing Excercise");
            Console.WriteLine($"2. Reflection Excercise");
            Console.WriteLine($"3. Listing Excercise");
            Console.WriteLine($"4. Exit");
            
            menuResponse = Console.ReadLine();

            if (menuResponse == "1") 
            {
                Breathing breathing = new Breathing();
                breathing.StartActivity();

            }
            else if (menuResponse == "2") 
            {
                Reflection reflection = new Reflection();
                reflection.StartActivity();
            }
            else if (menuResponse == "3") 
            {
                Listing listing = new Listing();
                listing.StartActivity();
            }
            else if (menuResponse == "4") 
            {
                Console.WriteLine("Exiting the Mindfulness Project. Goodbye!");
            }
            else 
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        } while (menuResponse != "4");


    }
}