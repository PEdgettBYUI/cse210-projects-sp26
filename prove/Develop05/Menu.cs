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
        Console.Clear();
        switch(choice)
        {
            // Create new goal object, and add it to the To-Do List.
            case 1:
                Console.Clear();
                Console.WriteLine("      Menu\n1.Create Simple Goal\n2.Create Eternal Goal\n3.Create Checklist Goal");
                int subChoice = ClementsFunctions.GetUserInputInteger("  Choose:");
                Console.Clear();
                switch(subChoice)
                {
                    /* TODO: Add Question Function for Name, Description, Points*/
                    // Simple Goal
                    case 1:
                        toDoList.AddGoalToToDoList(GoalQuestionaire("Simple"));
                        break;
                    // Eternal Goal
                    case 2:
                        toDoList.AddGoalToToDoList(GoalQuestionaire("Eternal"));
                        break;
                    // Checklist Goal
                    case 3:
                        toDoList.AddGoalToToDoList(GoalQuestionaire("Checklist"));
                        break;
                    default:
                        Console.WriteLine("[INVALID Input!] Please put in a Valid Entry.]\n");
                        break;
                }
                
                PressToContinue();
                break;
            // Display the current To-Do List of Goals
            case 2:
                Console.WriteLine(toDoList);
                
                PressToContinue();
                break;
            // Save the current To-Do List of Goals
            case 3:
                toDoList.SaveToDoList(ClementsFunctions.GetUserInputString("What will be the file name?"));
            
                PressToContinue();
                break;
            // Load a pre-existing To-Do List of Goals.
            // If "case 5" is called, this will guarantee no progress is lost before EXIT.
            case 4:
                toDoList.LoadToDoList(ClementsFunctions.GetUserInputString("What's the name of the TO-DO list you'd like to LOAD?"));
                
                PressToContinue();
                break;
            // Record the completion of a Goal-Event
            case 5:
                List<Goal> goalsList = toDoList.Get_goalToDoList();
                
                // Create a list to record the incomplete goals and their original indexes
                List<(Goal, int)> incompleteGoalsList = new List<(Goal, int)>();
                foreach (var goal in goalsList)
                {
                    if (!goal.Get_goalDone_PTE())
                    {
                        incompleteGoalsList.Add( (goal, goalsList.IndexOf(goal)) );
                    }
                }
                
                // Display the incomplete Goals
                if (incompleteGoalsList != null)
                {
                    int menuNumber = 1;
                    foreach (var goal in incompleteGoalsList)
                    {
                        Console.WriteLine($"{menuNumber}. {goal}");
                        menuNumber++;
                    }
                }
                
                // Prompt the user for which Goal to record to
                Console.WriteLine("\nWhich Goal Would you like to Record for?");
                int recordInput = ClementsFunctions.GetUserInputInteger("  Choose:");
                
                // Record the Goal from the toDoList
                var chosenGoal = incompleteGoalsList[(recordInput - 1)];
                // SHOULD: Take the recorded index, grab the Goal from that index in the toDoList and call .IsCompleted() on it.
                toDoList.Get_goalToDoList()[chosenGoal.Item2].IsCompleted();
                
                PressToContinue();
                break;
            // Exit the Program
            case 6:
                
                PressToContinue();
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
    // NOTE: Added a few Thread.Sleep delays in hopes that it will be more effective at blanking the console.
    private static void PressToContinue()
    {
        Console.Write("\n> Press Any Key to Continue ");
        Console.ReadKey();
        Thread.Sleep(1);
        Console.Clear();
        Thread.Sleep(1);
        Console.Clear();
        Thread.Sleep(1);
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
        name = ClementsFunctions.GetUserInputString("What's the Name of your Goal?");
        description = ClementsFunctions.GetUserInputString("Give a description for your Goal:");
        points = ClementsFunctions.GetUserInputInteger("How many points is your Goal worth?");

        // Return New GoalType
        switch (goalType)
        {
            case "Simple":
                return new Goal(name, description, points);
            case "Eternal":
                return new Eternal(name, description, points);
            case "Checklist":
                // Checklist Only
                finalCount = ClementsFunctions.GetUserInputInteger("How many times must you do your goal before it's complete?");
                bonusPoints = ClementsFunctions.GetUserInputInteger("What's the Bonus Points for completing your Goal?");

                return new Checklist(name, description, points, bonusPoints, finalCount);
        }
        // If no valid response is given, return nothing.
        throw new Exception("Invalid GoalType. Nothing Returned.");
        // return null;
    }
}