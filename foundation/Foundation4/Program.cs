using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity("4 April 2025", 30, 2));
        activities.Add(new CyclingActivity("1 April 2025", 60, 15));
        activities.Add(new SwimmingActivity("3 April 2025", 30, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
