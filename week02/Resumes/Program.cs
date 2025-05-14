using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Job job1 = new Job();
        job1._company = "Tech Corp";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2023;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Norco Inc.";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2019;
        job2._endYear = 2021;
        // job2.Display();
        
        Resume myResume = new Resume();
        myResume._name = "John Doe";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();

        }
}