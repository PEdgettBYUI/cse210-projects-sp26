/* 
*    Patrick T. Edgett 5/14/26
*       Sources:
*   1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*   2. https://github.com/PEdgettBYUI/cse210-projects-sp26 
    3. https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
*   4. https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
*   5. 
*/

public class Entry
{
    // variables for the class
    private string _date_PTE;
    private string _prompt_PTE;
    private string _response_PTE;

    // Lazy programmer's shame-Bar
    string bar_PTE = new String('-', 40);

    // Default Constructor
    public Entry()
    {
        PromptGenerator prompter_PTE = new PromptGenerator();
        // Records the current date at the time of entry creation
        _date_PTE = DateTime.Now.ToString("dddd, dd MMMM yyyy | h:mm tt");
        _prompt_PTE = prompter_PTE.GeneratePrompt();
        // Display the Prompt & get user response.
        _response_PTE = RecordResponse();
    }

    // "Load From File" Constructors
    public Entry(string dateFromFile, string promptFromFile, string responseFromFile)
    {
        _date_PTE = dateFromFile;
        _prompt_PTE = promptFromFile;
        _response_PTE = responseFromFile;
    }


    // Prompt User to record response to Entry
    public string RecordResponse()
    {
        DisplayEntry();
        // Console.WriteLine(_prompt_PTE); //NOTE: Make pretty
        Console.Write(">    ");
        return Console.ReadLine();
    }

    // Display the current entry in an appealing visual format
    public void DisplayEntry()
    {
        Console.WriteLine($"\n\n{_date_PTE}\n{bar_PTE}");
        Console.WriteLine($"  Today's Prompt:\n - {_prompt_PTE}\n");
        Console.WriteLine($"{_response_PTE}");
    }

    // Converts all the data in Entry to s #-seperated string
    public string ConvertToString()
    {
        string outputString_PTE = $"{_date_PTE}#{_prompt_PTE}#{_response_PTE}";
        return outputString_PTE;
    }
}