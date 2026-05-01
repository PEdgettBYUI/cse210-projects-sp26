using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!\n\n");

        
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string Name_PTE = Console.ReadLine();

        return Name_PTE;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string FavoriteNumber_PTE = Console.ReadLine();

        return int.Parse(FavoriteNumber_PTE);
    }

    static void PromptUserBirthYear(out int BirthYear_PTE)
    {
        Console.Write($"Please enter the year you were born: ");
        BirthYear_PTE = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int Num_PTE)
    {
        return Num_PTE * Num_PTE;
    }

    static void DisplayResult(string Name_PTE, int Square_PTE, int BirthYear_PTE)
    {
        Console.WriteLine($"{Name_PTE}, the square of your number is {Square_PTE}");
        Console.WriteLine($"{Name_PTE}, you will turn {2026 - BirthYear_PTE} this year.");
    }
}