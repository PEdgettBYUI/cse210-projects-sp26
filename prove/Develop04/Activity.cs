/* Patrick Thomas Edgett | Jacob Middledorf | 6/9/2026 
 * References
 * 1. https://chatgpt.com/share/6a2885b0-a200-83e8-931d-d90563abc586 - Get seconds from DateTime
 * 2. Had Chat tell me how to convert string to int due to tiredness and illness - PTE.
 * 3.
 *
 */
public class Activity {
    private string _Name_PTE;
    private string _Description_PTE;
    private int _Duration_PTE;
    protected DateTime _StartTime_PTE;
    // private DateTime _EndTime_PTE;


    


    public Activity(string Name, string Description, int Duration)
    {
        _Name_PTE = Name;
        _Description_PTE = Description;
        _Duration_PTE = Duration;
    }

    // See Ref. 2
    public void IntroMessage()
    {
        Console.WriteLine($"Welcome to the {_Name_PTE} Activity");
        Console.WriteLine(_Description_PTE);
        Console.Write("How long in seconds will this take? ");
        var userInputDuration_PTE = Console.ReadLine();

        if (int.TryParse(userInputDuration_PTE, out int duration))
        {
            _Duration_PTE = duration;
        }
        else
        {
            Console.WriteLine("Invalid number. Using 0 seconds.");
            _Duration_PTE = 0;
        }
    }

    public void ExitMessage()
    {
        Console.WriteLine("Well Done!");
        LoadingSpinner(20);
        Console.WriteLine($"You have completed another {_Duration_PTE} of the {_Name_PTE} Activity.");
        LoadingSpinner(20);
        Console.Clear();
    }

    public bool CheckDuration()
    {
        DateTime CurrentTime_PTE = DateTime.Now;
        DateTime EndTime_PTE = _StartTime_PTE.AddSeconds(_Duration_PTE);
        if(CurrentTime_PTE > EndTime_PTE) { 
            return true;
        } return false;
    }

    //Given a duration of "frames" the spinner will run for that time
    public void LoadingSpinner(int frames)
    {
        int counter = 0;
        int cycles = 0;
        while(cycles < 5)
        {
            if (counter == 5) { counter = -1; cycles++; };
            counter++;
            Thread.Sleep(250);   
            switch (counter % frames)
            {       
            case 0: Console.Write("/"); break;
            case 1: Console.Write("-"); break;
            case 2: Console.Write("\\"); break;
            case 3: Console.Write("|"); break;
            }    
        Console.Write("\b");
        }
    }
    
    public void LoadingCountdown(int StartTime)
    {
        // Current Design only works with Single Digit Values
        Console.Write(" ");
        while (StartTime > 0)
        {
            Console.Write("\b");
            // Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write($"{StartTime}");
            StartTime--;
        }
        Console.Write("\b");
        Console.Write("0\n");
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