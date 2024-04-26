using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {   /*Getting the numbers*/
        
        /*Console.WriteLine("What is the magic number?");
        string number = Console.ReadLine();
        int response = int.Parse(number);*/
        
        int guess2 = -1;
        int guessCount = 0;
        string again = "yes";
       
        /*Building my Random number*/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 99);

        /*Console.WriteLine("What is your guess?");
        
        string guess = Console.ReadLine();
        int guess2 = int.Parse(guess);*/

        /*Buildind my if statment*/
        
        /*if (guess2 < response) {
            Console.WriteLine("Higher!");
        }
        else if(guess2 > response) {
            Console.WriteLine("Lower!");
        }
        else {
            Console.WriteLine("You guessed it!");
        }*/
       
        /*Building my loop*/
        
        while (guess2 != magicNumber || again=="yes") {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            guess2 = int.Parse(guess);
            if (guess2 < magicNumber) {
            Console.WriteLine("Higher!");
            }
            else if(guess2 > magicNumber) {
            Console.WriteLine("Lower!");
            }
            else {
            Console.WriteLine("You guessed it!");
            Console.WriteLine("Do you want to play again?");
            again = Console.ReadLine();
            magicNumber = 0;
            }
            guessCount++;
        }
        Console.WriteLine($"You tried {guessCount} times!");

    }   
}