using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   Console.WriteLine("Welcome to the Journey program");
        string [] prompts = {
            "What was the most importante thing that happened today? ",
            "what was the most interesting person you talked to today? ",
            "What did you spend the most time on today? ",
            "How are you feeling after this day? "
        };

        Random randomprompt = new Random();
        int itemindex = randomprompt.Next(prompts.Length);
        string prompt = prompts[itemindex];

        Console.WriteLine(prompt);
        string answer = Console.ReadLine();

        try
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
        
            Console.WriteLine("Please enter the path of the file where you want to store your journey: ");
        
            string file = Console.ReadLine(); 
        
            //Write in the file, and shows your content
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                Console.Write($"Date: {date} - ");
                Console.WriteLine(prompt);
                Console.WriteLine(answer);
                writer.Write($"Date: {date} - ");
                writer.WriteLine(prompt);
                writer.WriteLine(answer);
                writer.Flush();
            }
            
            Console.WriteLine("Do you have another file to show your records: ");
            string anotherFile = Console.ReadLine();

            //Read the file content
            if(File.Exists(anotherFile))
            {
                string fileContent = File.ReadAllText(anotherFile);
                Console.WriteLine(fileContent);
            }
            else{
                Console.WriteLine("The file not found! ");
            } 

        }
        catch(Exception ex)
        {
            Console.WriteLine("An error ocurred while saving the journey information :( ");
        }      
    }
}