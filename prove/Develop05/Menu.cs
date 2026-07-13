/* References and Notes
 * 1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
 * 2. https://github.com/PEdgettBYUI/cse210-projects-sp26
 * 3. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 * 4. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 */
using Develop05;


class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("      Menu\n1.Create New Goal\n2.Load Journal\n3.Display Current Journal\n4.Save Current Journal\n5.Save Entry & Exit\n");
    }

    // NOTE: Pass in the name of a given journal to call the functions to. 
    public void ParseUserChoice(int choice)
    {   
        switch(choice)
        {
            // Create new goal object, and add it to the To-Do List.
            case 1:
                Console.Clear();
                Console.WriteLine("      Menu\n1.Create Simple Goal\n2.Create Eternal Goal\n3.Create Checklist Goal");
                int subChoice = int.Parse(Console.ReadLine());
                switch(subChoice)
                {
                    /* TODO: Add Question Function for Name, Description, Points*/
                    // Simple Goal
                    case 1:
                        Console.Clear();
                        Goal Simple = new Goal(Name,Description,Points);
                        break;
                    // Eternal Goal
                    case 2:
                        Console.Clear();
                        Goal Eternal = new Eternal(Name,Description,Points);
                        break;
                    // Checklist Goal
                    case 3:
                        /*TODO: Add extra questions for BonusPoints and FinalCount*/
                        Console.Clear();
                        Goal Checklist = new Checklist(Name,Description,Points, BonusPoints, FinalCount);
                        break;
                }
                Console.Clear();
                break;
            // Display the current To-Do List of Goals
            case 2:
                
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
    static private void PressToContinue()
    {
        Console.Write("\n> Press Any Key to Continue ");
        Console.ReadKey();
        Console.Clear();
        Console.Clear();
        Console.Clear();
    }
}