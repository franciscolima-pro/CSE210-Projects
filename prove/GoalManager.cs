using System;
using System.Collections.Generic;

class GoalManager
{
    private int _score;
    private List<Goal> _goals;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.ShortName);
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string option = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (option)
        {
            case "1":
                _goals.Add(new SimpleGoal(goalName, description, points));
                break;
            case "2":
                _goals.Add(new SimpleGoal(goalName, description, points));
                break;
            case "3":
                _goals.Add(new SimpleGoal(goalName, description, points));
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again!");
                break;
        }
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals()
    {
         string filename = "goals.txt";

    try
    {
        
        using (StreamWriter writer = new StreamWriter(filename))
        {
            
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving goals: {ex.Message}");
    }  
    }

    public void LoadGoals()
    {
            string filename = "goals.txt";

    try
    {
        if (File.Exists(filename))
        {
            
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;

                
                while ((line = reader.ReadLine()) != null)
                {
 
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No goals found. Start creating new goals.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading goals: {ex.Message}");
    }
    }
}