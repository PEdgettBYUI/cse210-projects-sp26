/* Patrick Thomas Edgett | Jacob Middledorf | 6/9/2026 
 * References
 * 1.
 * 2.
 * 3.
 *
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Develop04 World!\n\n");

        string BreatheDescrip_PTE = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string ReflectDescrip_PTE = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string ListDescrip_PTE = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


        Breathing BreathingAct = new Breathing("Breathing", BreatheDescrip_PTE, 20);
        Reflecting ReflectingAct = new Reflecting("Reflecting", ReflectDescrip_PTE, 20);
        Listing ListingAct = new Listing("Listing", ListDescrip_PTE, 20);

        bool done_PTE = false;
        // Menu
        while (!done_PTE)
        {
            Console.WriteLine("--- Activities Menus ---");
            Console.WriteLine("1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Exit");
            Console.Write("\nChoose: > ");
            int UserMenuSelect_PTE = 0;
            UserMenuSelect_PTE = int.Parse(Console.ReadLine());
        
            switch (UserMenuSelect_PTE)
            {   
                // Run Breathing Activity
                case 1: BreathingAct.RunBreathing(4, 6); break;
                // Run Reflecting Activity
                case 2: ReflectingAct.RunReflecting(); break;
                // Run Listing Activity
                case 3: ListingAct.RunListing(); break;
                // Exit
                case 4: done_PTE = true; break;
            }
        }
        Console.WriteLine("\nHave a Lovely Day!");
        Thread.Sleep(3000);
    }
}