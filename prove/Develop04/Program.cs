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
        Console.WriteLine("Hello Develop04 World!");

        Breathing bTest = new Breathing("Breathing", "ONCE UPON ZUUL", 20);

        bTest.RunBreathing(4, 6);
    }
}