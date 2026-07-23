
using System;
using System.Collections.Generic;

namespace TurnBasedFighter
{
    class Program
    {
        static Random rng = new Random();
        static Player player = new Player();
        static List<Monster> monsters = MonsterFactory.CreateMonsters();
        static int currentMonsterIndex = 0;

        static void Main(string[] args)
        {
            Menu.StartMenu();
        }

        static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Battle Arena!");

            while (currentMonsterIndex < monsters.Count)
            {
                Monster enemy = monsters[currentMonsterIndex];
                Console.WriteLine($"\nYou encounter a monster {enemy.Description}");
                Battle(enemy);

                if (enemy.IsDefeated())
                {
                    Console.WriteLine($"{enemy.Type} defeated");
                    player.RewardPoints(enemy.Difficulty);
                    currentMonsterIndex++;
                }
            }

            Console.WriteLine("\nCongratulations! You Won");
        }

        static void Battle(Monster enemy)
        {
            bool playerTurn = true;

            while (!enemy.IsDefeated() && player.HP > 0)
            {
                DisplayStatus(enemy);

                if (playerTurn)
                {
                    string action = Menu.BattleMenu();
                    ExecutePlayerAction(action, enemy);
                }
                else
                {
                    MonsterAction(enemy);
                }

                playerTurn = !playerTurn;
            }
        }

        static void ExecutePlayerAction(string action, Monster enemy)
        {
            int damage = 0;

            switch (action)
            {
                case "1": damage = Moves.Punch(enemy); break;
                case "2": damage = Moves.Kick(enemy); break;
                case "3": damage = Moves.Strike(enemy); break;
                case "4": damage = Moves.FireMagic(enemy); break;
                case "5": damage = Moves.IceMagic(enemy); break;
                case "6": damage = Moves.LightMagic(enemy); break;
                case "7": damage = Moves.Sword(enemy); break;
                case "8": damage = Moves.Gun(enemy); break;
                case "9": damage = Moves.Potion(player); break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine($"You dealt {damage} damage!");
            enemy.HP -= damage;
        }

        static void MonsterAction(Monster enemy)
        {
            int damage = enemy.AttackPower;
            Console.WriteLine($"{enemy.Type} attacks you for {damage} damage!");
            player.HP -= damage;
        }

        static void DisplayStatus(Monster enemy)
        {
            Console.WriteLine($"\nPlayer HP: {player.HP}");
            Console.WriteLine($"{enemy.Type} HP: {enemy.HP}");
        }

        public static void StartGameWrapper()
        {
            StartGame();
        }
    }

}
