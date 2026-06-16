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

        Breathing BreathingAct = new Breathing("Breathing", "ONCE UPON ZUUL", 20);
        Reflecting ReflectingAct = new Reflecting("Reflecting", "ONCE UPON ZUUL", 20);
        // Listing ListingAct = new Listing("Listing", "ONCE UPON ZUUL", 20);

        bool done_PTE = false;
        // Menu
        while (!done_PTE)
        {
            Console.WriteLine("--- Activities Menus ---");
            Console.WriteLine("1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Exit");
            Console.Write("\nChoose: > ");
            int UserMenuSelect_PTE = int.Parse(Console.ReadLine());
        
            switch (UserMenuSelect_PTE)
            {   
                // Run Breathing Activity
                case 1: BreathingAct.RunBreathing(4, 6); break;
                // Run Reflecting Activity
                case 2: ReflectingAct.RunReflecting(); break;
                // Run Listing Activity
                // case 3: ListingAct.RunListing(); break;
                // Exit
                case 4: done_PTE = true; break;
            }
            Console.WriteLine("\nHave a Lovely Day!");
            Thread.Sleep(3000);
        }
    }
}