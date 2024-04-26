using System;

class Program
{
    static void Main(string[] args)
    {
        static void  welcomeFunction () {
            Console.WriteLine("Welcome to program!");
        }
        

        static string userName (){
            Console.Write("Please enter your name: ");
            string yourname = Console.ReadLine();
            return yourname;
        }
        
        static int userNumber (){
            Console.Write("Please enter your favorite number: ");
            string userinput = Console.ReadLine();
            int yournumber = int.Parse(userinput);
            return yournumber;
        }

        static int squareNumber () {
            int squarepilot = userNumber();
            int squareResult = squarepilot * squarepilot;
            return squareResult;
        }

        static void displayresults () {
            string name = userName();
            int square = squareNumber();
            Console.WriteLine($"{name}, the square of your number is: {square}");
            
        }
        
        welcomeFunction();
        displayresults();
    }
}