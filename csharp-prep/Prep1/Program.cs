// Patrick Thomas Edgett
// 4/23/2026
// This program is a simple demonstration of reading and writing strings to the console


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!\n");

        Console.Write("What is your first name? ");
        string FirstName_PTE = Console.ReadLine();

        Console.Write("What is your last name? ");
        string LastName_PTE = Console.ReadLine();

        Console.WriteLine($"\nYour name is {LastName_PTE}, {FirstName_PTE} {LastName_PTE}\n\n");
    }
}