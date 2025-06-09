public class Breathing : Activity
{


// Constructor with no parameters
    public Breathing() : base("Breathing", "This activity will help you relax by guiding you through deep breathing exercises.", 0)
    {}

// Constructor with duration parameter
    public Breathing(string activityName, string activityDescription, int duration) : base(activityName, activityDescription, duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }

    public void StartActivity()
    {
        DisplayIntroMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4); // Simulate breathing in for 4 seconds
            Console.WriteLine("Breathe out...");
            ShowSpinner(4); // Simulate breathing out for 4 seconds
        }
        
        DisplayEndMessage();
    }


}