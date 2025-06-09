using System.ComponentModel;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _duration; // Duration of the activity in seconds

    

    public Activity()
    {}

    public Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }

    public void DisplayIntroMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity!\n");
        Console.WriteLine(_activityDescription);
        
        Console.Write("How long would you like to spend on this activity (in seconds)? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine("Get Ready..."); // have the time cout down here
        ShowCountdown(5);
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done! \n");
        ShowSpinner(6);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} activity.");
        ShowSpinner(6);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> animations = new List<string>{"|","/","-","\\"};
        int animationIndex = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animations[animationIndex]);
            animationIndex++;
            Thread.Sleep(500); // speed of the spinner
            Console.Write("\b \b"); // Clear the last character
            
            if (animationIndex>= animations.Count)
            {
                animationIndex= 0; // Reset the index to loop through the animations
            }
        }
        Console.WriteLine(); // Move to the next line after the spinner completes

    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > -1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Clear the last character
        }
        // Show a countdown timer for the specified number of seconds
        // This could be a simple console countdown
    }

}