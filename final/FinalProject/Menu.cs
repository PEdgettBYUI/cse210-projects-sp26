/* References and Notes
 * 1. Class documentation: https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
 * 2. https://github.com/PEdgettBYUI/cse210-projects-sp26
 * 3. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 * 4. https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
 */

namespace Develop05;

    static class Menu
    {
        public static void StartMenu()
        {
            while (true)
            {
                Console.WriteLine("=== MAIN MENU ===");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Quit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Program.StartGameWrapper();
                    return;
                }
                else if (choice == "2")
                {
                    Environment.Exit(0);
                }
            }
        }

        public static string BattleMenu()
        {
            Console.WriteLine("\nChoose your action:");
            Console.WriteLine("Fighting Moves:");
            Console.WriteLine(" 1. Punch");
            Console.WriteLine(" 2. Kick");
            Console.WriteLine(" 3. Strike");

            Console.WriteLine("Magic Moves:");
            Console.WriteLine(" 4. Fire Magic");
            Console.WriteLine(" 5. Ice Magic");
            Console.WriteLine(" 6. Light Magic");

            Console.WriteLine("Items:");
            Console.WriteLine(" 7. Sword");
            Console.WriteLine(" 8. Gun");
            Console.WriteLine(" 9. Potion");

            Console.Write("Choose: ");
            return Console.ReadLine();
        }
    }