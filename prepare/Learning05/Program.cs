using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Gray", 5.5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Retangle retangle = new Retangle("Magenta", 8.9, 13.4);
        Console.WriteLine(retangle.GetColor());
        Console.WriteLine(retangle.GetArea());

        Circle circle = new Circle("Brown", 10.8);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}