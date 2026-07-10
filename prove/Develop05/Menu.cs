/* 
*    Patrick T. Edgett 5/14/26
*       Sources:
*    1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*    2. https://github.com/PEdgettBYUI/cse210-projects-sp26
*    3. 
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
            // Create new entry and add it to the journal.
            case 1:
                Console.Clear();
                Console.WriteLine("      Menu\n1.Create Simple Goal\n2.Create Eternal Goal\n3.Create Checklist Goal");
                int subChoice = int.Parse(Console.ReadLine());
                switch(subChoice)
                {
                    case 1:
                        Console.Clear();
                        Goal Simple = new Goal(Name,Discription,Points);
                        break;
                    case 2:
                        Console.Clear();
                        Goal Eternal = new Goal(Name,Discription,Points);
                        break;
                    case 3:
                        Console.Clear();
                        Goal Checklist = new Goal(Name,Discription,Points);
                        break;
                }

                Console.Clear();
                break;
            // Load an existing journal.
            case 2:
                
                PressToContinue();
                break;
            // Display each entry in the current journal.
            case 3:
            
                PressToContinue();
                break;
            // Save the current journal to a text file.
            // If "case 5" is called, this will guarantee no progress is lost before EXIT.
            case 4:
            case 5:
                
                
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