public class RunningActivity : Activity
{
    private double _distance; // in miles

    public RunningActivity(string date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override string GetName()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _duration * 60;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }
}