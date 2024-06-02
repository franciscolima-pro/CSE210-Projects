using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Ana St", "Bananeiras", "Paraíba", "Brazil");

        Lecture lecture = new Lecture("Tech Innovations", "A talk on the latest in tech.", "2023-06-15", "10:00 AM", address1, "Dr. John Doe", 100);
        Reception reception = new Reception("Networking Event", "Meet and greet with professionals.", "2023-07-20", "6:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "A fun day out for the family.", "2023-08-12", "11:00 AM", address3, "Sunny with a chance of rain");

        List<Event> events = new List<Event>{lecture, reception, outdoorGathering};

        foreach (Event evnt in events)
        {
            Console.WriteLine(evnt.getStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evnt.getFullDetails());
            Console.WriteLine();
            Console.WriteLine(evnt.getShortDetails());
            Console.WriteLine();        
        }
    }
}