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
        string input_PTE;
        int userChoice_PTE = ClementsFunctions.GetUserInputInteger();

        do
        {
            Console.WriteLine("\n  ~ Your Goal-E ~");
            GoalMenu.DisplayMenu();
            Console.Write("Chose: ");


        } while (userChoice_PTE != 6);

    }
}