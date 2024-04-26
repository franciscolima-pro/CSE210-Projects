using System;
using System.Transactions;
using System.Collections.Generic; /*In addition for my collections*/
class Program
{
    static void Main(string[] args)
    {

        List<int> myNumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished!"); /*My title*/
        
        /*Primary variables*/
        
        int enter = -1;
        int sum = 0;

        /*My loop for ask the numbers*/
       
        while (enter!=0) {
        Console.WriteLine("Enter number: ");
        string response = Console.ReadLine();
        enter = int.Parse(response);
        if (enter!=0) {
            myNumbers.Add(enter);
        }}
        
        /*sum the numbers with my variable sum*/
        
        foreach (int item in myNumbers) {
            sum += item;
        }

        /*Select the first number of the list, if the next number is bigger than it, it will be replaced.*/

        int largest = myNumbers[0];
        
        foreach (int item in myNumbers) {
            if (item > largest) {
                largest = item;
            }
        }
        
       /*Getting the smallest positive number*/ 
        
        int smallest = largest;

        foreach (int item in myNumbers){
            if ( item > 0 && item < smallest ) {
                smallest = item;
            }

        } 
        
        /*Finding my average, wich is the sum of 'the numbers divided by the quantity iof numbers in my list'*/

        double average = (double) sum / myNumbers.Count;

        /*Printing the results*/

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"Smallest Number is: {smallest}");

        /*Making a sorted list;*/ 

        myNumbers.Sort();

        Console.WriteLine("The sorted list is: ");

        foreach (int item in myNumbers){
            Console.WriteLine(item);         
        } 

    }
    
}