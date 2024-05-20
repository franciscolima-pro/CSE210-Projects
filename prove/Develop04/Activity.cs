using System;
class Activity
{
    private string _name;
    private string _description;
 
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.Write("\b \b");
        Console.WriteLine("Get ready...");//separate
    }
    public void DisplayEndMessage(int _duration)
    {
        Console.WriteLine($"Well Done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> _spinner = new List<string>();
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");
        _spinner.Add("|");

        DateTime startime = DateTime.Now;
        DateTime endtime = startime.AddSeconds(seconds);
        int index = 0;
        while (DateTime.Now < endtime)
        {
            string item = _spinner[index];
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            index++;
            if(index >= _spinner.Count)
            {
                index = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int item = seconds ; item > 0 ;  item --)
        {
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}