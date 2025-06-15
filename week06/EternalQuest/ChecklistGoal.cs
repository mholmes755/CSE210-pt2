public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus)
        : base(shortName, description, points)
    {
        _targetAmount = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        int earned = _points;

        if (IsComplete())
        {
            earned += _bonus;
            Console.WriteLine($"Checklist complete! Bonus: {_bonus} points!");
        }

        Console.WriteLine($"Progress: {_amountCompleted}/{_targetAmount}. Points earned: {earned}");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()} -- Completed: {_amountCompleted}/{_targetAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_targetAmount}|{_amountCompleted}";
    }
}
