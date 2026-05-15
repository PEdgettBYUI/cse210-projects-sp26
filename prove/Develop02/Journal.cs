/* 
*    Patrick T. Edgett 5/14/26
*       Sources:
*    1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*    2. https://github.com/PEdgettBYUI/cse210-projects-sp26
*    3. 
*/
using System.IO;

public class Journal
{
    private string _journalName_PTE;
    private List<Entry> _entries_PTE;

    // Constructor
    public Journal()
    {
        _entries_PTE = new List<Entry>();
        // _journalName_PTE = NameJournal();
    }

    // Name the Journal
    // NOTE: Messed up the constructor, this is a temporary fix
    public void NameJournal()
    {
        Console.Write("What's the name of your Journal? ");
        // string name_PTE = Console.ReadLine();

        // Console.WriteLine($"[Journal Created: {name_PTE}");
        // return name_PTE;
        _journalName_PTE = Console.ReadLine();
    }

    public string getName()
    {
        return _journalName_PTE;
    }

    // Add an Entry object to the list of Entries.
    public void AddEntry(Entry entry) { _entries_PTE.Add(entry); }
    
    // Display all entries in the current Journal
    public void DisplayAll()
    {
        foreach (Entry log in _entries_PTE)
        {
            log.DisplayEntry();
            Console.WriteLine("---------------------------------------\n");
        }
        Console.WriteLine($"--Total Entries: {_entries_PTE.Count}--\n");
    }

    // LOAD journal from a given filename .text-file (needs to end in .txt)
    public void LoadJournal(string filename)
    {
        // Open the given file name
        if (System.IO.File.Exists(filename))
        {
            string[] lines_PTE = System.IO.File.ReadAllLines(filename);

            // Read each line from the file
            foreach (string line in lines_PTE)
            {
                // Split the line into parts at the '#'
                string[] parts_PTE = line.Split("#");
                // Use the split parts to instance an Entry with the "Loading" constructor
                string f_date_PTE = parts_PTE[0];
                string f_prompt_PTE = parts_PTE[1];
                string f_response_PTE = parts_PTE[2];

                Entry f_entry = new Entry(f_date_PTE, f_prompt_PTE, f_response_PTE);
                // Append the new entry to the current journal's _entries list
                this.AddEntry(f_entry);
            }
            Console.WriteLine($"[Journal: \"{filename}\" Loaded.");
        }
        else
        {
            // Error message
            Console.WriteLine($"ERROR!\nThe File: \"{filename}\" Does Not Exist within the save directory.\nPlease provide an existing filename.\n\n");
        }
    }

    // SAVE entries in _entries_PTE<> to [_journalName_PTE].text-file
    public void SaveJournal()
    {
        //Check if the list has entires, if not, Output error message
        if (_entries_PTE.Count >0) {
            // Using StreamWriter, go through _entries and output each Entry's ConvertToString()
            // NOTE: Streamwriter will create a new file of the given filename.txt if it does not exist already
            using (StreamWriter outputFile = new StreamWriter(_journalName_PTE + ".txt"))
            {
                foreach (Entry entry in _entries_PTE)
                {
                    outputFile.WriteLine(entry.ConvertToString());
                }
            }
        }
        else
        {
            // Error message
            Console.WriteLine("[NO Entries. SAVE Failed.]");
        }

    }
}