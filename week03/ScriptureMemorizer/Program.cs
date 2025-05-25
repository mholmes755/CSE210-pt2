using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Jonh", 3, 16, 17);
        Scripture scripture = new Scripture(reference, "\n16. For God so loved the world that he gave his only begotten Son, that whosoever believeth in him shall not perish, but have everlasting life. \n17. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");


        string scriptureText = scripture.GetDisplayText();
        string referenceText = reference.GetDisplayText();

        do
        {
             Console.WriteLine($"{referenceText}: {scriptureText}");

            Console.WriteLine("\nPress enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return; // Exit the program
            }
            else if (input == "")
            {
                Console.Clear();
                Console.WriteLine(" ");
                scripture.HideRandomWords(3);
                scriptureText = scripture.GetDisplayText(); // call method to update scripture text

                // Console.WriteLine($"{referenceText}: {scripture.GetDisplayText()}");


            }

        } while (!scripture.IsCompletelyHidden());
       

    }
}



