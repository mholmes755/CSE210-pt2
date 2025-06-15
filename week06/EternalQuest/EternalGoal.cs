public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal '{_shortName}' recorded. You earn {_points} points every time you complete it.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}