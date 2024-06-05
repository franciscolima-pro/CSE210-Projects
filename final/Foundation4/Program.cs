using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[]
        {
            new Running ("04/06/2024", 40, "Running", 5.9),
            new Cycling("06/06/2024", 50, "Cycling", 10),
            new Swimming("08/06/2024", 100, "Swimming", 25)
        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.getSumary());
        }
    }
}