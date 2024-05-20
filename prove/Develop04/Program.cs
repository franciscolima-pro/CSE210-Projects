using System;

class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start Breathing Activity");
        Console.WriteLine(" 2. Start Reflecting Activity");
        Console.WriteLine(" 3. Start Listing Activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");
        string _menu = Console.ReadLine();

        switch (_menu)
        {
            case "1":
                BreathingActivity breathingactivity = new BreathingActivity();
                breathingactivity.Run();
                break;
            case "2":
                ReflectingActivity reflectingactivity = new ReflectingActivity();
                reflectingactivity.Run();
                break;
            case "3":
                ListingActivity listingactivity = new ListingActivity();
                listingactivity.Run();
                break;
            case "4":
                break;
            default:
                break;
        }
    }
}