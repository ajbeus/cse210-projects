using System;
using System.IO;
using System.IO.Enumeration;

public class Journal
{
    List<Entry> entries = new List<Entry>();
    PromptGenerator promptGenerator = new PromptGenerator();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. View all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                WriteEntry();
                break;
                
                case "2":
                DisplayEntries();
                break;

                case "3":
                SaveToFile();
                break;

                case "4":
                LoadFromFile();
                break;

                case "5":
                return;

                default:
                    Console.WriteLine("Invalid choice. ");
                    Console.WriteLine(" ");

                    break;

            }
        }
    }

    private void WriteEntry()
    {
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(name, prompt, response);
        entries.Add(newEntry);

        Console.WriteLine("Entry has been added");
        Console.WriteLine(" ");
    }

    private void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
    private void SaveToFile()
    {
        Console.WriteLine("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._name}|{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
        Console.WriteLine("Journal saved successfully. ");
        Console.WriteLine(" ");
    }
    private void LoadFromFile()
    {
        Console.WriteLine("Enter the filename to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. ");
            Console.WriteLine(" ");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 4)
            {
                Entry entry = new Entry(parts[0], parts[2], parts[3])
                {
                    _date = parts[1]
                };
                entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully.");
        Console.WriteLine(" ");
    }


    }