// Patrick Thomas Edgett
// 4/23/2026
// This program is a simple grade evaluator. It takes a given numerical value
// and provides an appropriate letter grade. The program will also account for
// + & - variations of given letter grades, except for A+, F+, and F-, which are
// not recognized as valid grades.

using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!\n");

        Console.Write("What is your grade(%)? ");
        string UsrInp_PTE = Console.ReadLine();
        
        float GradeNum_PTE = float.Parse(UsrInp_PTE);
        char GradeLet_PTE = 'E';

        // Logic Map for A to F
        if (GradeNum_PTE >= 90)
        {
            
        }

    }
}