public class Activity
{
    protected double _duration;
    protected string _date;

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual string GetName()
    {
        return "Activity";
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetName()} ({_duration} minutes) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}