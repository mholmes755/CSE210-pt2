public class Reflection : Activity
{

    private List<string> _prompts;
    private List<string> _questions;

// Constructor with no parameters
    public Reflection() : base("Reflecting", "This activity will help you reflect on times when you have shown strength and resilience. This will help you realize the power you have and how you can use it in other aspects of your life. You will be given a prompt then a series of questions to consider about that prompt. You will have 15 seconds to ponder each question. ", 0)
    {
        _prompts = new List<string> // I could also initialize this list in the attributes list at the beginning of the class 
        {
            "Think of a time when you overcame a challenge.",
            "Reflect on a moment when you felt proud of yourself.",
            "Consider a situation where you showed resilience in the face of adversity.",
            "Recall a time when someone else was inspired by your actions.",
            "Remember a moment when you learned something valuable about yourself."

        };

        _questions = new List<string>
        {
            "What did you learn from this experience?",
            "How did it make you feel?",
            "What strengths did you discover in yourself?",
            "How can you apply this strength in your current life?",
            "What would you tell someone else who is facing a similar challenge?"
        };
    }
    
// Constructor with duration parameter
    public Reflection(string activityName, string activityDescription, int duration, List<string> prompts, List<string> questions) : base(activityName, activityDescription, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void StartActivity()
    {
        DisplayIntroMessage();
        Console.WriteLine();

        DisplayPrompt();
        DisplayQuestions();


        DisplayEndMessage();
        Console.Clear();
    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }


    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }


    public void DisplayPrompt()
    {
        Console.Clear();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Reflect on the following prompt: \n---- {prompt} ----");
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();

    }



    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Now, ponder each of the following questions as they relate to this experience: ");
        
        
        while(DateTime.Now < endTime)
        {
            
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinner(15); // Give the user 10 seconds to think about the question
            Console.WriteLine();
        }

    }
 

}