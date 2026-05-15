/* 
*    Patrick T. Edgett 5/14/26
*       Sources:
*    1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*    2. 
*    3. 
*/
class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("      Menu\n1.Create New Entry\n2.Load Journal Entry\n3.Display Current Journal\n4.Save Current Journal\n5.Save Entry & Exit\n");
    }

    // NOTE: Pass in the name of a given journal to call the functions to. 
    public void ParseUserChoice(int choice, Journal aJournal)
    {
        switch(choice)
        {
            // Create new entry and add it to the journal.
            case 1:
                Entry newEntry_PTE = new Entry();
                aJournal.AddEntry(newEntry_PTE);
                break;
            // Load an existing journal.
            // NOTE: Remember to append ".txt"
            case 2:
                Console.Write("What's the name of the Journal you want to LOAD? ");
                string fileInput_PTE = Console.ReadLine();
                aJournal.LoadJournal(fileInput_PTE + ".txt");
                Console.WriteLine($"[Journal: \"{fileInput_PTE}\" Loaded.");
                break;

            // Display each entry in the current journal.
            case 3:
                aJournal.DisplayAll();
                break;

            // Save the current journal to a text file.
            // If "case 5" is called, this will guarantee no progress is lost before EXIT.
            case 4 & 5:
                aJournal.SaveJournal();
                break;
            // Invalid input case
            default:
                Console.WriteLine("[INVALID Input!] Please put in a Valid Entry.]\n");
                break;
        }
    }
}