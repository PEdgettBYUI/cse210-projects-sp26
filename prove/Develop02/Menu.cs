/* 
*    Patrick T. Edgett 5/14/26
*       Sources:
*    1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*    2. https://github.com/PEdgettBYUI/cse210-projects-sp26
*    3. 
*/
class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("      Menu\n1.Create New Entry\n2.Load Journal\n3.Display Current Journal\n4.Save Current Journal\n5.Save Entry & Exit\n");
    }

    // NOTE: Pass in the name of a given journal to call the functions to. 
    public void ParseUserChoice(int choice, Journal aJournal)
    {   
        switch(choice)
        {
            // Create new entry and add it to the journal.
            case 1:
                Console.Clear();
                Entry newEntry_PTE = new Entry();
                aJournal.AddEntry(newEntry_PTE);

                Console.Clear();
                break;
            // Load an existing journal.
            case 2:
                Console.Write("What's the name of the Journal you want to LOAD? ");
                string fileInput_PTE = Console.ReadLine();
                aJournal.LoadJournal(fileInput_PTE);

                PressToContinue();
                break;
            // Display each entry in the current journal.
            case 3:
                aJournal.DisplayAll();

                PressToContinue();
                break;
            // Save the current journal to a text file.
            // If "case 5" is called, this will guarantee no progress is lost before EXIT.
            case 4:
            case 5:
                if (aJournal.EntiresCount() > 0)
                {   
                    aJournal.SaveJournal();
                    Console.WriteLine($"[JOURNAL Saved!]\n[SAVED as: {aJournal.getName()}.txt]");
                
                    PressToContinue();
                }
                else { Console.WriteLine("[NO Entries. SAVE Failed.]"); }

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