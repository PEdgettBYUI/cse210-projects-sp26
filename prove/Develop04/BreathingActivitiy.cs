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
        IntroMessage();
        
        Console.WriteLine("Get Ready...");
        LoadingSpinner(5);
        Console.Clear();
        
        _StartTime_PTE = DateTime.Now;
        while(!CheckDuration())
        {
            Console.Write("Breath In... ");
            LoadingCountdown(InTime);   // (InTime)
            Console.Write("Breathe Out... ");
            LoadingCountdown(OutTime);   // (OutTime)
        }
        ExitMessage();
    }
}