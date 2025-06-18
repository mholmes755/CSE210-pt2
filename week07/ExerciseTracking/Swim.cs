public class Swim : Exercise
{
    private int _laps; // number of laps


    public Swim(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetPace()
    {
        // Pace in minutes per lap
        double pace = (double)_laps / _duration; // Duration in laps per minute
        double roundedPace = Math.Round(pace, 2);
        return roundedPace; // Round to 2 decimal places
    }

    public override double GetDistance()
    {
        // Assuming each lap is 50 meters
        double distance = _laps * 50; // Distance in meters
        return distance; // Round to 2 decimal places
    }

    public override string GetSummary()
    {
        return $"Swim on {_date.ToShortDateString()} for {_duration} minutes, covering a distance of {GetDistance()} meters at a pace of {GetPace():0.00} laps per minute.";
    }
    



}