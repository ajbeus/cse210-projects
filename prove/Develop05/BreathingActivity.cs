public class BreathingActivity : Activity
{
    public BreathingActivity()
        :base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void RunActivity()
    {
        DisplayIntro();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(5);
            Console.WriteLine("Breathe out...");
            Countdown(5);
        }
        Console.WriteLine("Well done!");
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}