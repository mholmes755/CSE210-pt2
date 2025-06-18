public class Bike : Exercise
{
    private int _speed; 


    public Bike(DateTime date, int duration, int speed) : base(date, duration)
    {
        _speed = speed; // Speed in km/h
    }

    // public override double GetPace()
    // {
    //     // Pace in minutes per kilometer

    //     double pace = (double)60.0 / _speed; // Speed in km/h, so pace is in minutes/km
    //     return Math.Round(pace, 2); // Round to 2 decimal places
    // }

    public override double GetDistance()
    {
        // Distance in kilometers
        double distance = (_speed * _duration) / 60.0; // Speed in km/h, duration in minutes
        return Math.Round(distance, 2); // Round to 2 decimal places
    }

    public override string GetSummary()
    {
        return $"Bike on {_date.ToShortDateString()} for {_duration} minutes at a speed of {_speed} mph, covering a distance of {GetDistance()}.";
    }


}