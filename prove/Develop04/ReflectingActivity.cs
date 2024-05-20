class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflectiong Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "How can you keep this experience in mind in the future?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself through this experience?",
            "What could you learn from this experience that applies to other situations?"
        };
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

        while (DateTime.Now < endTime)
       {
            Console.WriteLine("Consider the following prompt: ");
            DisplayPrompt();
            Console.WriteLine("When you have something in mind, press 'Enter' to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they realted to this experience");
            Console.WriteLine("You may begin in...");
            ShowCountDown(5);
            while (DateTime.Now < endTime)
            {
                DisplayQuestion();
                ShowSpinner(10);
            }      
       }
       DisplayEndMessage(activityDuration);
    }
    public string getHandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string getHandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        string prompt = getHandomPrompt();
        Console.WriteLine(prompt);
    }
    public void DisplayQuestion()
    {
        string question = getHandomQuestion();
        Console.WriteLine(question);
    }
}