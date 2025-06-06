using System;

class Program
{
    static void Main(string[] args)
    {
        HomeworkAssignment assignment1 = new HomeworkAssignment("Rebecca Stuart", "Ancient Mesoamerican Literature");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        Math assignment2 = new Math("Blake Perez","PreCalculus","Section 4.5","16-25");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        Writing assignment3 = new Writing("James Bradshaw","Advanced Business Writing","Business Communication Strategies");
        Console.WriteLine(assignment3.GetWritingInfo());
        Console.WriteLine();
    }
}