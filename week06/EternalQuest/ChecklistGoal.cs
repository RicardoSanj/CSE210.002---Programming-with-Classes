public class ChecklistGoal : Goal
{
    private int _currentCount;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int currentCount, int targetCount, int bonusPoints)
        : base(name, points)
    {
        _currentCount = currentCount;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
                return Points + _bonusPoints;
            else
                return Points;
        }
        return 0;
    }

    public override string GetDetails()
    {
        return $"[{_currentCount}/{_targetCount}] {Name}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{Name}|{Points}|{_currentCount}|{_targetCount}|{_bonusPoints}";
    }
}
