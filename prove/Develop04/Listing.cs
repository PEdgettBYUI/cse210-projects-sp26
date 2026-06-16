using System;
using System.Collections.Generic;
using System.Threading;

class Listing : Activity
{
    public Listing(string Name, string Description, int Duration) 
        : base(Name, Description, Duration) {}
    public void RunListing()
    {

        IntroMessage();
        // Console.Write("How many seconds would you like the activity to last? ");
        // int _Duration_PTE = int.Parse(Console.ReadLine());
        // Console.WriteLine();

        Console.WriteLine("Get Ready...");
        LoadingSpinner(5);
        
        // List of prompts
        string[] prompts =
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // Select a random prompt
        Random rand = new Random();
        string randPrompt = prompts[rand.Next(prompts.Length)];
      
        Console.WriteLine($"--- {randPrompt} ---");


        // Countdown before listing begins
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Press Enter after each item.");


        // Collect items for the duration
        List<string> items = new List<string>();
        // DateTime endTime = DateTime.Now.AddSeconds(_Duration_PTE);

        _StartTime_PTE = DateTime.Now;

        // while (DateTime.Now < endTime)
        while (!CheckDuration())
        {
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
    }
}