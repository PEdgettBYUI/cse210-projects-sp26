// Program made by Team 1: Jacob Middledorf & Patrick Edgett  |  July 9th, 2026
/* References and Notes
 * 1. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 */
using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Develop05 World!\n\n");
        
        // Initialize Objects
        ToDoList GoalList = new ToDoList();
        Menu GoalMenu = new Menu();
        
        // Initialize Variables
        int userChoice_PTE = 0;
        
        
        // "Main" Program Loop; Loop Until User enters Exit value 6
        do
        {
            // Display Menu & Prompt user for choice
            Console.WriteLine("\n  ~ Your Goal-E ~");
            GoalMenu.DisplayMenu();
            
            // Get User Input and Parse to Int
            userChoice_PTE = ClementsFunctions.GetUserInputInteger("  Choose: ");
            GoalMenu.ParseUserChoice(userChoice_PTE, GoalList);

        } while (userChoice_PTE != 6);
        

    }
}