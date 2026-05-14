/* 
*    Patrick T. Edgett 5/14/26
*       Sources:
*    1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*    2. 
*    3. 
*/
public class Journal
{
    private string _journalName_PTE;
    private List<Entry> _entries_PTE;

    // Constructor
    public Journal()
    {
        
    }

    // Add an Entry object to the list of Entries.
    public void AddEntry(Entry entry) { _entries_PTE.Add(entry); }
    
    // Display all entries in the current Journal
    public void DisplayAll()
    {
        foreach (Entry log in _entries_PTE)
        {
            log.DisplayEntry();
            Console.WriteLine("\n---------------------------------------\n");
        }
        Console.WriteLine($"--Total Entries: {_entries_PTE.Count}--\n");
    }

    // LOAD
    public void LoadJournal(string filename)
    {
        // Open the given file name
        // Read each line from the file
        // Split the line into parts at the '#'
        // Use the split parts to instance an Entry with the "Loading" constructor
        // Append the new entry to the current journal's _entries list
    }

    // SAVE entries in _entries_PTE<> to a given filename text-file
    public void SaveJournal(string filename)
    {
        //Check if the list has entires, if not, Output error message
        if (_entries_PTE.Count >0) {
            // Using StreamWriter, go through _entries and output each Entry's ConvertToString()
            using (StreamWriter outputfile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries_PTE)
                {
                    outputfile.WriteLine(entry.ConvertToString());
                }
            }
        }
        else
        {
            Console.WriteLine("[NO Entries. SAVE Failed.]");
        }

    }
}