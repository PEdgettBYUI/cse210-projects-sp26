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
                Console.WriteLine("MAIN MENU");
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
            Console.WriteLine("Select your move:\nAttack:\n1.Punch DNG:{Damage} SPEED:{Speed}\n2.Kick DNG:{Damage} SPEED:{Speed}\nMagic:\n3. Fireball DNG:{Damage} SPEED:{Speed}\n4. Air Cannon DNG:{Damage} SPEED:{Speed}\n5. Rock Throw DNG:{Damage} SPEED:{Speed}\nItems:\n6. Gun DNG:{Damage} SPEED:{Speed}\n7. Sword DNG:{Damage} SPEED:{Speed}\n8. HP Potion DNG:{Damage} SPEED:{Speed}");
            Console.Write("Choose: ");
            return Console.ReadLine();
        }
    }