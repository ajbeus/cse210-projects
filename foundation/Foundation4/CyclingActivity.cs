public class CyclingActivity : Activity
{
    private double _speed; // mph

    public CyclingActivity(string date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override string GetName()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return _speed * _duration / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }
}