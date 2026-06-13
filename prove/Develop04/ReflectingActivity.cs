/* Patrick Thomas Edgett | Jacob Middledorf | 6/9/2026 
 * References
 * 1.
 * 2.
 * 3.
 *
 */
 using System.Text.Json;
using Microsoft.VisualBasic;
public class Reflecting : Activity
{
    string _ReflectingPrompt_PTE;
    List<string> _PromptList_PTE;
    List<string> _QuestionList_PTE;
    public Reflecting(string Name, string Description, int Duration) 
        : base(Name, Description, Duration)
    {
        _PromptList_PTE = [ // Taken from Develop Instructions/Example
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."];
        _QuestionList_PTE = [ // Taken from Develop Instructions/Example
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"];
    }


    private void JsonInterpreter(string filename)
    {
    if (filename.Contains(".json")) {    
            // See Reference 2.     (Use for testing -> "NT-Truncated-lds-scriptures-filtered.json")
            string json_PTE = File.ReadAllText(filename);

            var _ScriptureObject_PTE =
                JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, List<string>>>>(json_PTE);
            if (_ScriptureObject_PTE == null) {
                throw new Exception("Failed to deserialize scripture data.");
            }

            // Get Randoms Prompt for reflection
            _ReflectingPrompt_PTE = RandomString(_PromptList_PTE);

        }
        else {throw new Exception("NOT A VALID JSON FILE");}
    }
    
    // Gets random string from a given list (Prompt OR Question)
    private string RandomString(List<string> arrayName)
    {
        Random random_PTE = new Random();
        string contents_PTE = arrayName[random_PTE.Next(arrayName.Count)];
        return contents_PTE;
    }

    public void RunReflecting()
    {
        _StartTime_PTE = DateTime.Now;
        IntroMessage();
        LoadingSpinner();
        
        while(!CheckDuration())
            Console.Write($"\n{RandomString(_QuestionList_PTE)}");
            LoadingSpinner();
        ExitMessage();
    }

}