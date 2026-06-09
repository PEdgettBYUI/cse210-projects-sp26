/* Patrick Thomas Edgett | Jacob Middledorf | 6/9/2026 
 * References
 * 1. https://chatgpt.com/share/6a2885b0-a200-83e8-931d-d90563abc586 - Get seconds from DateTime
 * 2.
 * 3.
 *
 */
public class Activity {
    private string _Name_PTE;
    private string _Description_PTE;
    private int _Duration_PTE;
    private DateTime _StartTime_PTE;
    private DateTime _EndTime_PTE;


    public Activity(string Name, string Description, int Duration)
    {
        _Name_PTE = Name;
        _Description_PTE = Description;
        _Duration_PTE = Duration;
    }

    public string IntroMessage()
    {
        return "TEMP Intro";
    }

    public string ExitMessage()
    {
        return "TEMP Exit";
    }

    public void RunActivity()
    {
        _StartTime_PTE = DateTime.Now;
        _EndTime_PTE = _StartTime_PTE.AddSeconds(_Duration_PTE);
    }

    public bool CheckDuration()
    {
        DateTime CurrentTime_PTE = DateTime.Now;
        if(CurrentTime_PTE > _EndTime_PTE)
        {
            return true;
        }
        return false;
    }

    public void LoadingSpinner()
    {
        Console.WriteLine("SPIN");
    }
    
    public void LoadingCountdown()
    {
        Console.WriteLine("3...2...1...");
    }


    /*  // Comeback after Polymorphism
    public void RunActivity(void* (int callback()) )
    {
        
        IntroMessage();
        LoadingSpinner();
        int TimePassed = 0;
        while(!CheckDuration(TimePassed)) {
            TimePassed = callback();
        }
    }
*/
}