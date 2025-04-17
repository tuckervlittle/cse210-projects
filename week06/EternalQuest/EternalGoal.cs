public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }
    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}, {_description}, {_points}";
    }
    public override string ToSaveString()
    {
        return $"Eternal Goal,{_shortName},{_description},{_points}";
    }
}