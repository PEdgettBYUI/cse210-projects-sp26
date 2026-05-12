public class Entry
{
    // variables for the class
    private string _date_PTE;
    private string _prompt_PTE;
    private string _response_PTE;

    // Default Constructor?
    public Entry(string genPrompt)
    {
        // Records the current date at the time of entry creation
        _date_PTE = DateTime.Now.ToString("MMMM dd, yyyy");
        // Records prompt from the entry passed to it
        _prompt_PTE = genPrompt;
    }
    // "Load From File" Constructors
    public Entry(string dateFromFile, string promptFromFile, string responseFromFile)
    {
        _date_PTE = dateFromFile;
        _prompt_PTE = promptFromFile;
        _response_PTE = responseFromFile;
    }


    // Prompt User to record response to Entry
    public void recordResponse()
    {
        Console.Write(">    ");
        _response_PTE = Console.ReadLine();
    }

    // Converts all the data in Entry to s #-seperated string
    public string ConvertToString()
    {
        string outputString_PTE = $"{_date_PTE}#{_prompt_PTE}#{_response_PTE}";
        return outputString_PTE;
    }
}