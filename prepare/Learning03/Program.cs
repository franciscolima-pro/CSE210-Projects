using System;
using System.Security.Authentication;

class Program
{
    public class Fraction 
    {
        private int _top;
        private int _bottom;
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int wholeNumber) 
        {
            _top = wholeNumber;
            _bottom = 1;
        }

        public Fraction (int top, int bottom){
             _top = top;
            _bottom = bottom;
        }

        public string GetFractionString()
        {
            string text = $"{_top}/{_bottom}";
            return text;
        }
        public double GetDecimalValue()
         {
            return (double)_top / (double)_bottom;
        }
    }
        static void Main(string[] args)
    {
        Fraction fracone =  new Fraction();
        Console.WriteLine(fracone.GetFractionString());
        Console.WriteLine(fracone.GetDecimalValue());

        Fraction fractwo = new Fraction(8);
        Console.WriteLine(fractwo.GetDecimalValue());
        Console.WriteLine(fractwo.GetDecimalValue());

        Fraction fracthree = new Fraction(3, 5);
        Console.WriteLine(fracthree.GetFractionString());
        Console.WriteLine(fracthree.GetDecimalValue());

        Fraction fracfour = new Fraction();
        Console.WriteLine(fracfour.GetFractionString());
        Console.WriteLine(fracfour.GetDecimalValue());

    }
}
