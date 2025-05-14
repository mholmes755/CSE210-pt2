public class Job{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        // Console.WriteLine($"Company: {_company}");
        // Console.WriteLine($"Job Title: {_jobTitle}");
        // Console.WriteLine($"Start Year: {_startYear}");
        // Console.WriteLine($"End Year: {_endYear}");

    }
}