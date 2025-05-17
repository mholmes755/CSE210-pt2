public class Entry{
    public string _date;
    public string __promptText;
    public string _entryText;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {__promptText}");
        Console.WriteLine($"Entry: {_entryText}");

    }
}