public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailString()
    {
        bool completed = IsComplete();
        double percentComplete = (double)_amountCompleted / _target * 100;
        double percentRemaining = 100 - percentComplete;
        return $"[{(completed ? "X" : " ")}] {_shortName}: {_description} -- Amount Remaining: {percentRemaining}%";
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}";
    }
    public override string ToSaveString()
    {
        return $"Checklist Goal,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}