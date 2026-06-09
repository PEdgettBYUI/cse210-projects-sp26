/* Patrick Thomas Edgett | Jacob Middledorf | 6/9/2026 
 * References
 * 1.
 * 2.
 * 3.
 *
 */
public class Activity {
    private string _Name;
    private string _Description;
    private int _Duration;


    public Activity(string Name, string Description, int Duration)
    {
        _Name = Name;
        _Description = Description;
        _Duration = Duration;
    }

    public string IntroMessage()
    {
        return "TEMP Intro";
    }

    public string ExitMessage()
    {
        return "TEMP Exit";
    }

    // public void RunActivity()
    // {
        // Comeback after Polymorphism
    // }

    public bool CheckDuration(int CountFrom)
    {
        return true;
    }

    public void LoadingSpinner()
    {
        Console.WriteLine("SPIN");
    }
    
    public void LoadingCountdown()
    {
        Console.WriteLine("3...2...1...");
    }
}