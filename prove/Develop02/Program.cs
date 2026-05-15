/* 
*    Patrick T. Edgett 5/14/26
*       Sources:
*    1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*    2. 
*    3. https://chatgpt.com/share/6a06620b-69dc-83e8-8722-bc50f1466cee
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Program Introduction
        Console.WriteLine("Welcome to DigiJourn, \n    your Digital Journaling Companion.\n\n");

        // Initialize classes
        Menu mainMenu_PTE = new Menu();
        Journal currentJournal_PTE = new Journal();

        // Initialize variables for Main
        string input_PTE;
        int userChoice_PTE = 0;

/*          // NOTE: Made a critical error in the construction of the class that I cannot fix at this time,
            //   I will try to amend this later
        // Ask the User to Create New Journal or Load Journal
        do {
        Console.Write("Are you LOADING an existing Journal? (y/n)\n> ");
        input_PTE = Console.ReadLine();
        }
        while (input_PTE != "y" && input_PTE != "n");

        currentJournal_PTE = new Journal();
        // Load Journal
        if (input_PTE == "y")
        {
            string journalFileName_PTE = currentJournal_PTE.getName() + ".txt";
            currentJournal_PTE.LoadJournal(journalFileName_PTE);
        }
        // Tell the User their Journal was created
        else if (input_PTE == "n")
        {
            Console.WriteLine($"[Journal Created] Name: {currentJournal_PTE.getName()}");
        }
*/
        

        // Begin Main Program Loop
        while (userChoice_PTE != 5)
        {
            // Display Menu & prompt user for choice
            Console.WriteLine("\n  --DigiJourn--");
            mainMenu_PTE.DisplayMenu();
            Console.Write("Chose: ");

            // Make sure the user input is valid before parsing
            input_PTE = Console.ReadLine();
            if(!int.TryParse(input_PTE, out userChoice_PTE))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            // parse the User's choice, if 5, also print a closing message
            mainMenu_PTE.ParseUserChoice(userChoice_PTE, currentJournal_PTE);
            if(userChoice_PTE == 5)
            {
                Console.WriteLine("[CLOSING program...]\n[Goodbye!]");
            }
        }
    }
}