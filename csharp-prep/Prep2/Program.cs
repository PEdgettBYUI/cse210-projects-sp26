// Patrick Thomas Edgett
// 4/23/2026
// This program is a simple grade evaluator. It takes a given numerical value
// and provides an appropriate letter grade. The program will also account for
// + & - variations of given letter grades, except for A+, F+, and F-, which are
// not recognized as valid grades.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!\n");

        char GetSign_PTE(float GradeVal)
        {
            int digit = (int)Math.Round(GradeVal);  // ChatGPT recommended method of conversion "Casting"
                                            // By rounding up, we fix incorrectly given signs (i.e 83.2 Should be a 'B', NOT 'B-')
            char Modifier_PTE;
            if (digit % 10 >= 7) {
                Modifier_PTE = '+';
            }
            else if (digit % 10 <= 3) {
                Modifier_PTE = '-';
            }
            else {
                Modifier_PTE = '\0';    // \0 is the NUL char value
            }
            return Modifier_PTE;
        }

        Console.Write("What is your grade(%)? ");
        string UsrInp_PTE = Console.ReadLine();
        
        if (!float.TryParse(UsrInp_PTE, out float temp)) return; // or handle error     // ChatGPT Error Handling Suggestion
        float GradeNum_PTE = Math.Abs(temp);
        char GradeLet_PTE = 'E';
        char Sign_PTE = '\0';   // \0 is the NUL char value

        // Logic Map for A to F
        if (GradeNum_PTE >= 90) // A, A-
        {
            GradeLet_PTE = 'A';
            if (GradeNum_PTE < 97) {Sign_PTE = GetSign_PTE(GradeNum_PTE);}
        }
        else if (GradeNum_PTE >= 80)    // B, B+, B-
        {
            GradeLet_PTE = 'B';
            Sign_PTE = GetSign_PTE(GradeNum_PTE);
        }
        else if (GradeNum_PTE >= 70)    // C, C+, C-
        {
            GradeLet_PTE = 'C';
            Sign_PTE = GetSign_PTE(GradeNum_PTE);
        }
        else if (GradeNum_PTE >= 60)    // D, D+, D-
        {
            GradeLet_PTE = 'D';
            Sign_PTE = GetSign_PTE(GradeNum_PTE);
        }
        else if (GradeNum_PTE < 60) // F
        {
            GradeLet_PTE = 'F';
        }

        // Display letter grade
        Console.WriteLine($"Your final grade is {GradeLet_PTE}{Sign_PTE}.");

    }
}