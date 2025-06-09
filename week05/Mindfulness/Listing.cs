using System.Dynamic;

public class Listing : Activity
{

    private int _responseCount;
    private List<string> _prompts;


// Constructor with no parameters
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as you can in a certain area.", 0)
    {
        _prompts = new List<string>
        {
            "List the things that you were grateful for today.",
            "List as many things as you can that you want to achieve in the next year.",
            "List as many things as you can that you love about yourself.",
            "List the times when you felt the spirit today.",
            "List the family members that you are grateful for."
        };
    }
    
// Constructor with duration parameter
    public Listing(string activityName, string activityDescription, int duration, List<string> prompts) : base(activityName, activityDescription, duration)
    {
        
    }



    public void StartActivity()
    {
        DisplayIntroMessage();
        Console.WriteLine();
        Console.Clear();

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        string prompt = GetRandomPrompt();
        Console.Write($"---- {prompt} ----\n");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _responseCount++;
        }
        

        DisplayEndMessage();
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        // This method should return a random prompt for the user to list items about
        // For example, "List as many things as you can that make you happy."
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }

}