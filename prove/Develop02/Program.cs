using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)   
    {
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void WriteToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.PromptText}");
                writer.WriteLine($"Entry: {entry.EntryAnswer}");
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
        _entries.Clear(); // Clear existing entries before loading from file

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string date = reader.ReadLine().Replace("Date: ", "");
                string prompt = reader.ReadLine().Replace("Prompt: ", "");
                string entry = reader.ReadLine().Replace("Entry: ", "");
                reader.ReadLine(); // Read empty line after each entry

                _entries.Add(new Entry(date, prompt, entry));
            }
        }
    }
}

public class Entry
{
    public string Date { get; }
    public string PromptText { get; }
    public string EntryAnswer { get; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryAnswer = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryAnswer}");
        Console.WriteLine();
    }
}

public class PromptGenerator
{
    private string[] _prompts = {
        "What was the most important thing that happened today? ",
        "What was the most interesting person you talked to today? ",
        "What did you spend the most time on today? ",
        "How are you feeling after this day? ",
        "What did you learn today?",
        
    };

    private Random _random;

    public PromptGenerator()
    {
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Length);
        return _prompts[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journey program");

        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Write to a file");
            Console.WriteLine("2. Read from a file");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteToFile(journal, promptGenerator);
                    break;
                case "2":
                    ReadFromFile(journal);
                    break;
                case "3":
                    Console.WriteLine("Thanks!");
                    return;
                default:
                    Console.WriteLine("Please type a valid option!");
                    break;
            }
        }
    }

    static void WriteToFile(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string answer = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy/MM/dd");

        Console.WriteLine("Please enter the path of the file where you want to store your journey: ");
        string file = Console.ReadLine();

        journal.AddEntry(new Entry(date, prompt, answer));
        journal.WriteToFile(file);
    }

    static void ReadFromFile(Journal journal)
    {
        Console.WriteLine("Enter the path of the file you want to read: ");
        string file = Console.ReadLine();

        journal.LoadFromFile(file);
        journal.DisplayAllEntries();
    }
}
