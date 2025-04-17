public class SimpleGoal : Goal
{
    public bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
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

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailString()
    {
        return _isComplete ? $"[X] {_shortName}: {_description}" : base.GetDetailString();
    }
    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }
    public override string ToSaveString()
    {
        return $"Simple Goal,{_shortName},{_description},{_points},{_isComplete}";
    }
}