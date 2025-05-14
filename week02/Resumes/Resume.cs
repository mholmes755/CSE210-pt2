public class Resume{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_name}");

    // For each instance of the "Job" class
    // in the "_jobs" list, create variable "job"
    // and call the "Display" method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}