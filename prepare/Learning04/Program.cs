using System;

class Program
{

    static void Main(string[] args)
    {
       Assignment assignment = new Assignment("Mary Waters", "European History");
       Console.WriteLine(assignment.GetSummary());
       mathAssignment mathassignment = new mathAssignment("7.5","5-20");
       Console.WriteLine(mathassignment.GetWorkHomeList());
       WritingAssignment writingassignment = new WritingAssignment("The Causes of World War II");
       Console.WriteLine($"{assignment.GetSummary()}");
       Console.WriteLine($"{writingassignment.GetInfo()} by {assignment.GetName()}");
    }
}