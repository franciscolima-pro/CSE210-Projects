using System;
class BreathingActivity : Activity
{
    private int activityDuration;
    public BreathingActivity() : base($"Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("What time in seconds, would you like to spend in this activity? ");
        string time = Console.ReadLine();
        Console.WriteLine("Get Ready...");
        ShowSpinner(10);
        activityDuration = int.Parse(time);
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(activityDuration);
        while (DateTime.Now < endTime)
       {
            Console.WriteLine("Breathe in... ");
            ShowCountDown(5);
            Console.WriteLine("Now Breathe out... ");
            ShowCountDown(5);
       }
       DisplayEndMessage(activityDuration);
    }
}