public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * .62;
    }
    public override double GetSpeed()
    {
        double speed = GetDistance() / (getMinutes() / 60.0);
        return speed;
    }
    public override double GetPace()
    {
        return getMinutes() / GetDistance();
    }
}