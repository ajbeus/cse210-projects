using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing Activity");
        Console.WriteLine("4. Quit");

        int userInput = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                BreathingActivity breathing = new BreathingActivity();
                breathing.RunActivity();
                break;

            case 2:
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.RunActivity();
                break;

            case 3:
                ListingActivity listing = new ListingActivity();
                listing.RunActivity();
                break;

            case 4:
                Console.WriteLine("Thank you, have a great day!");
                break;

        }

    }
}