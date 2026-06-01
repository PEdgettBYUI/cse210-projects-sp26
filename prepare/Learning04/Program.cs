using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Learning04 World!\n");

        Assignment multiplying = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine($"{multiplying.GetSummary()}\n");

        MathAssignment fractions = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment euroHist = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        // Math Assignment Test
        Console.WriteLine($"GetHomeworkList():\n{fractions.GetHomeworkList()}\n");
        Console.WriteLine($"Summary:\n{fractions.GetSummary()}\n");

        // Writing Assignment Test
        Console.WriteLine($"GetWritingInformation:\n{euroHist.GetWritingInformation()}\n");
        Console.WriteLine($"Summary:\n{euroHist.GetSummary()}\n");

    }
}