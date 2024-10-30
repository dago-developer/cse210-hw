class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => $"{_name}: {(IsComplete() ? "[X] Completed" : "[ ] Not completed")}";

    public override string GetStringRepresentation() => $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
}
