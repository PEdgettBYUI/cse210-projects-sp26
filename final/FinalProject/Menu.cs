/* References and Notes
 * 1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
 * 2. https://github.com/PEdgettBYUI/cse210-projects-sp26
 * 3. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 * 4. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 */

namespace Develop05;

internal class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("      Menu\n1.Create New Goal\n2.Display TO-DO List\n3.Save TO-DO List\n4.Load TO-DO List\n5.Record Event\n6.Exit Program\n");
    }

    // NOTE: Pass in the name of the ToDo List with the User's choice 
    public void ParseUserChoice(int choice, ToDoList toDoList)
    {   
        switch(choice)
        {
            // Create new goal object, and add it to the To-Do List.
            case 1:
                Console.Clear();
                Console.WriteLine("      Menu\n1.Create Simple Goal\n2.Create Eternal Goal\n3.Create Checklist Goal");
                int subChoice = ClementsFunctions.GetUserInputInteger(Console.ReadLine());
                switch(subChoice)
                {
                    /* TODO: Add Question Function for Name, Description, Points*/
                    // Simple Goal
                    case 1:
                        Console.Clear();
                        toDoList.AddGoalToToDoList(GoalQuestionaire("Simple"));
                        break;
                    // Eternal Goal
                    case 2:
                        Console.Clear();
                        toDoList.AddGoalToToDoList(GoalQuestionaire("Eternal"));
                        break;
                    // Checklist Goal
                    case 3:
                        Console.Clear();
                        toDoList.AddGoalToToDoList(GoalQuestionaire("Checklist"));
                        break;
                }
                
                PressToContinue();
                Console.Clear();
                break;
            // Display the current To-Do List of Goals
            case 2:
                Console.WriteLine(toDoList);
                
                PressToContinue();
                Console.Clear();
                break;
            // Save the current To-Do List of Goals
            case 3:
            
                PressToContinue();
                Console.Clear();
                break;
            // Load a pre-existing To-Do List of Goals.
            // If "case 5" is called, this will guarantee no progress is lost before EXIT.
            case 4:
                
                
                PressToContinue();
                Console.Clear();
                break;
            // Record the completion of a Goal-Event
            case 5:
                
                
                PressToContinue();
                Console.Clear();
                break;
            // Exit the Program
            case 6:
                
                PressToContinue();
                Console.Clear();
                break;
            // Invalid input case
            default:
                Console.Clear();
                Console.WriteLine("[INVALID Input!] Please put in a Valid Entry.]\n");
                
                break;
        }
    }

    // "Helper" Functions
    
    // A Lazy attempt to clear the console even when the terminal window is compressed.
    // NOTE: Not as helpful as I had hoped :\
    private static void PressToContinue()
    {
        Console.Write("\n> Press Any Key to Continue ");
        Console.ReadKey();
        Console.Clear();
        Console.Clear();
        Console.Clear();
    }
    
    
    // Takes a given string and prompts the user for inputs to be used in a Goal Constructor
    static private Goal GoalQuestionaire(string goalType)
    {
        //Goal-Type Parameters
        string name;
        string description;
        int points;
        // Checklist Only
        int bonusPoints;
        int finalCount;
        
        // Get Info
        Console.Write("What's the Name of your Goal? ");
        name = ClementsFunctions.GetUserInputString();

        Console.Write("Give a description for your Goal: ");
        description = ClementsFunctions.GetUserInputString();

        Console.Write("How many points is your Goal worth? ");
        points = ClementsFunctions.GetUserInputInteger(" ");

        // Return New GoalType
        switch (goalType)
        {
            case "Simple":
                return new Goal(name, description, points);
            case "Eternal":
                return new Eternal(name, description, points);
            case "Checklist":
                // Checklist Only
                Console.Write("How many times must you do your goal before it's complete? ");
                finalCount = ClementsFunctions.GetUserInputInteger(Console.ReadLine());
                Console.Write("What's the Bonus Points for completing your Goal? ");
                bonusPoints = ClementsFunctions.GetUserInputInteger(Console.ReadLine());

                return new Checklist(name, description, points, bonusPoints, finalCount);
        }
        // If no valid response is given, return nothing.
        throw new Exception("Invalid GoalType. Nothing Returned.");
        // return null;
    }
}