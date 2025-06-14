public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points, bool isComplete) : base(name, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetDetails()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {Name}";
    }

    public override string Serialize()
    {
        return $"SimpleGoal|{Name}|{Points}|{_isComplete}";
    }
}
