public class Journal
{
    private List<Entry> _entries_PTE = new List<Entry>();

    // Add an Entry object to the list of Entries.
    public void addEntry(Entry entry) { _entries_PTE.Add(entry); }
    

    // Display all entries in the current Journal
    public void DisplayAll()
    {
        foreach (Entry log in _entries_PTE)
        {
            log.displayEntry();
            Console.WriteLine("\n---------------------------------------\n");
        }
    }
}