using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the Menu: ");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again!");
                    break;
            }
        }
    }
}