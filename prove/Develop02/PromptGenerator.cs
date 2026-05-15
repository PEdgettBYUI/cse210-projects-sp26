/* 
*    Patrick T. Edgett 5/14/26
*       Sources:
*    1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
*    2. 
*    3. 
*/
public class PromptGenerator
{
    // List of prompts used for Entry class
    private List<string> _prompts_PTE = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today ?",
        "If I had one thing I could do over today, what would it be?",
        "What's one new thing you learned today?",
        "What's something productive you've done today?",
        "What's something you read/watched today?",
        "Did you see anyone interesting today?"
    };

    public string GeneratePrompt()
    {
        // Get a random index from the _prompts_PTE list & return it.
        Random randVal = new Random();
        string selectPrompt = _prompts_PTE[randVal.Next(_prompts_PTE.Count)];
        return selectPrompt;
    }

}