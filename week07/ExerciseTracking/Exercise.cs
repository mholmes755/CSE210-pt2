public abstract class Exercise
{
    protected DateTime _date;
    protected int _duration; // in minutes

    protected List<Exercise> _exercises = new List<Exercise>();



    // method to get pace(minutes/mile)
    // method to get distance gone
    // method to get speed

    // method to dsplay summary

    public Exercise(DateTime date, int duration)
    {
        _date = date;
        _duration = duration; // In minutes
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public abstract double GetDistance(); // in meters

    // public abstract double GetSpeed(); // in km/h

    public abstract string GetSummary();



}