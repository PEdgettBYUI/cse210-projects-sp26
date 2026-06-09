/* Patrick Thomas Edgett | Jacob Middledorf | 6/9/2026 
 * References
 * 1.
 * 2.
 * 3.
 *
 */
public class Breathing : Activity
{
    public Breathing(string Name, string Description, int Duration) 
        : base(Name, Description, Duration) {}
    
    public void RunBreathing(int InTime, int OutTime)
    {
        _StartTime_PTE = DateTime.Now;
        IntroMessage();
        LoadingSpinner();
        
        while(!CheckDuration())
            Console.Write("Breath In... ");
            LoadingCountdown();   // (InTime)
            Console.Write("Breathe Out... ");
            LoadingCountdown();   // (OutTime)

        ExitMessage();
    }
}