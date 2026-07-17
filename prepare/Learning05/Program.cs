using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Learning05 World!\n");

        Shape box1 = new Square("yellow", 7);

        Console.WriteLine(box1.GetColor());
        Console.WriteLine(box1.GetArea());
    }
}