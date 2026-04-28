using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Game start Initialized
        string replay_PTE = "y";
        do {
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

            // Initialize Variables
            string guess_PTE;   // User input of Guess
            int n_guess_PTE;    // Converted Guess to Int
            int tries_PTE = 0;  // Count of Guesses

            // Start Game; Game ends if guess == magicNum
            do {
                tries_PTE++;
                Console.Write("What's your guess? ");
                guess_PTE = Console.ReadLine();
                n_guess_PTE = int.Parse(guess_PTE);

                // Compare if guess is Higher or Lower than MagicNum
                if (n_guess_PTE > magicNum_PTE)
                {
                    Console.Write("Too High.");
                }
                else if (n_guess_PTE < magicNum_PTE)
                {
                    Console.Write("Too Low."); 
                }
            }
            while (n_guess_PTE != magicNum_PTE);
            // Congrats Message
            Console.WriteLine("YOU'VE WON!!!!!!!!!");
            // Show number of tries
            Console.WriteLine($"It took you {tries_PTE} tries!\n\n");

            // Ask to continue or not; if not, then exit
            Console.WriteLine("Do you want to play again?\nType 'y' to replay, or press ENTER to EXIT.");
            replay_PTE = Console.ReadLine();
        }
        while (replay_PTE == "y");
    }
}