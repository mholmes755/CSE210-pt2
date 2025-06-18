public class Run : Exercise
{
    private double _distance; // in meters


    public Run(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }


    public override double GetPace()
    {
        // Pace in minutes per mile
        double paceInMilesPerMinute = (_distance / 1609.34) / (_duration / 60.0); // Convert distance to miles
        return (double)paceInMilesPerMinute;
    }

    public override double GetDistance()
    {
        // Distance in meters
        return _distance;
    }
    public override string GetSummary()
    {
        return $"Run on {_date.ToShortDateString()} for {_duration} minutes at a pace of {GetPace():0.00} miles/hour, covering a distance of {GetDistance()} meters.";
    }
}