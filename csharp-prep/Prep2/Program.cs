using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percent = Console.ReadLine();
        int percentage = int.Parse(percent);
        int sob = percentage % 10;
        string letter = " ";
        string sign = " ";
        
        
        if (percentage >= 90  ) {
            letter = "A";
        }
        else if (percentage >= 80) {
            letter = "B";
        }
        else if (percentage >= 70) {
            letter = "C";
        }
        else if (percentage >= 60) {
            letter = "D";
        }
        else{
            letter = "F";
        }

        if (sob < 3 ) {
            if (letter == "F") {
                sign = "";
            } else {
                sign = "-";
            }
        }
        else if (sob >= 7 ) {
            if (letter == "A" && sob >= 7 || letter == "F" &&  sob >= 7) {
                sign = "";
            } else {
                sign = "+";
            }
        }
        else {
            sign = " ";
        }
        
        if (percentage >= 70 ) {
            Console.WriteLine ($"Your grade is {letter}{sign}");
            Console.WriteLine("Congratulations, You Passed!");
        }
        else {
            Console.WriteLine ($"Your grade is {letter}{sign}");
            Console.WriteLine("Sorry, you didn't pass that time!");
            Console.WriteLine("But don't be discouraged, and try again next time!");
        }
    }
}
