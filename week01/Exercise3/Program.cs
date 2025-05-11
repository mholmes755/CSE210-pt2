using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string playAgain="";
        do {    

            Random randomGenerator = new Random();
            int secrectNumber = randomGenerator.Next(1, 101); 
            int guess;
            int guessCount = 0;
            int max = 100;
            int min = 1;
            
            do {
                    Console.WriteLine($"Guess a number between {min} and {max}");
                    guess = int.Parse(Console.ReadLine());
                    guessCount++;

                    if (guess > secrectNumber)
                    {
                        max = guess;
                        Console.WriteLine("Try a little lower!");
                        Console.WriteLine(" ");
                    }
                    else if (guess < secrectNumber)
                    {
                        min = guess;
                        Console.WriteLine("Try a little higher!");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        if (guessCount == 1){
                            Console.WriteLine($"Congratulations! You guessed the secret number in {guessCount} try!");
                        }
                        else
                        {
                           Console.WriteLine($"Congratulations! You guessed the secret number in {guessCount} tries!");

                        }
                    }

                } while (guess != secrectNumber);
                
            Console.WriteLine("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "yes");


    }
}