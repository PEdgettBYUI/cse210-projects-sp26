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

                break;

            // Load an existing journal.
            case 2:

                break;

            // Display each entry in the current journal.
            case 3:

                break;

            // Save the current journal to a text file.
            case 4:

                break;

            // Call Case 4 to Save & Close the Program
            case 5:

                break;

            // Invalid input case
            default:
                Console.WriteLine("[INVALID Input!]");
                break;
        }
    }
}