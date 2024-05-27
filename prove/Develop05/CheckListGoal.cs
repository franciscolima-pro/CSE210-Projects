class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"Amount Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        string completionStatus = IsComplete() ? "Completed" : "Not Completed";
        return base.GetStringRepresentation() + $" - {completionStatus}";
    }
}