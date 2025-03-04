public class Activity
{

    public string _name;
    public string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayIntro()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Animation(2);
    }

    public void Animation(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("—");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b");
        }
    }
}