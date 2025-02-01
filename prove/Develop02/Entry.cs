using System;

public class Entry
{
    public string _name;
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string name, string prompt, string response)
    {
        _name = name;
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("MM/dd/yyyy");

    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("--------------");
    }
}