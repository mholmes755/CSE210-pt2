using System;

class Program
{
    static void Main(string[] args)
    {
        string todaysDate = DateTime.Now.ToString("MMM, dd, yyyy");
        Run run1 = new Run(DateTime.Parse(todaysDate), 15, 3400);
        Run run2 = new Run(DateTime.Parse(todaysDate), 20, 4500); 

        Swim swim1 = new Swim(DateTime.Parse(todaysDate), 30, 153);
        Swim swim2 = new Swim(DateTime.Parse(todaysDate), 25, 120);
      
        Bike bike1 = new Bike(DateTime.Parse(todaysDate), 120, 20);
        Bike bike2 = new Bike(DateTime.Parse(todaysDate), 60, 15);
      

        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(run1);
        exercises.Add(run2);
        exercises.Add(swim1);
        exercises.Add(swim2);
        exercises.Add(bike1);
        exercises.Add(bike2);

        Console.Clear();

        foreach (var exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
            Console.WriteLine("\n--------------------\n");

        }

    }
}