public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, double duration, double laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override string GetName()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _duration * 60;
    }

    public override double GetPace()
    {
        return Math.Round(_duration / GetDistance());
    }
}