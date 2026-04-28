using System;

class Program
{
    static void Main(string[] args)
    {
        // Program introduction
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("This is the Number Guesser Game");
        Console.WriteLine("In this game, you will give us the \'Magic Number\', and we will choose a number from 1 to that number\nthat you have to guess!\nAim for the lowest number of tries!");

        // Default RNG Max value
        int maxNum_PTE = 100;

        // Initialize Magic Number
        Random randGen_PTE = new Random();
        int magicNum_PTE = randGen_PTE.Next(1,maxNum_PTE);
        Console.WriteLine($"Game Difficulty: 1 to {maxNum_PTE}\n\n");
        // Console.WriteLine($"Magic Num: {magicNum_PTE}\n"); // TEST
    }
}