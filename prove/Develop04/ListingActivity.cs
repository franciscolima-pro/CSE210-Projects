using System.Collections.Generic;
using System.Globalization;
class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    }
    // exceeding the requirements, new constructors
    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(RandomPrompt());
    }
    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("What time in seconds, would you like to spend in this activity? ");
        string time = Console.ReadLine();
        Console.WriteLine("Get Ready...");
        ShowSpinner(10);
        int activityDuration = int.Parse(time);
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(activityDuration);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        DisplayQuestion();
        Console.WriteLine("You may begin in...");
        ShowCountDown(5);
        
        _count = 0;
        List<string> responses = new List<string>();
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            responses.Add(response);
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner(10);
        DisplayEndMessage(activityDuration);
    }
}
