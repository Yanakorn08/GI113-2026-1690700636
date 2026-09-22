/*
 * Student ID : 1690700636
 * Name       : Yanakorn Rodclom
 * Section    : 129A
 * No.        : 26
 * Course     : GI113 Computer Programming (GI)
 */

using System.Security.Cryptography;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rollA = random.Next(1, 21);
            int rollB = random.Next(1, 21);
            int rollC = random.Next(1, 21);
            int monsterRoll = random.Next(1, 21);

            string heroName = "Joshep";
            int heroHP = 50;
            int heroDamage = 10;
            int heroDefense = 4;

            string monsterName = "Goblin";
            int monsterHP = 20;
            int monsterDamage = 8;
            int monsterDefense = 5;

            Console.WriteLine("========== START BATTER ==========");
            Console.WriteLine();
            Console.WriteLine($"Monster : {monsterName}");
            Console.WriteLine($"HP : {monsterHP}");
            Console.WriteLine();
            Console.WriteLine($"Hero : {heroName}");
            Console.WriteLine($"HP : {heroHP}");
            Console.WriteLine();
            Console.WriteLine("========== SKILLS ==========");
            Console.WriteLine();
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Escape");
            Console.WriteLine();
            Console.Write("Choose a skill (1-3) : ");
            bool success = int.TryParse(Console.ReadLine(), out int skillChoice);
            Console.WriteLine();

            if (skillChoice == 1)
            {
                Console.WriteLine($"You Attack the {monsterName}!");
                Console.WriteLine($"You deal {(heroDamage - monsterDefense)} damage!");
                Console.WriteLine($"The {monsterName} has {monsterHP - (heroDamage - monsterDefense)} HP left!");
            }
            else if (skillChoice == 2)
            {
                Console.WriteLine($"You Defend!");
                Console.WriteLine($"You take {(monsterDamage - heroDefense)} damage!");
                Console.WriteLine($"{heroName} has {heroHP - (monsterDamage - heroDefense)} HP left!");
            }
            else if (skillChoice == 3)
            {
                Console.WriteLine($"You try to Escape");
                Console.WriteLine($"Success! You escaped from the battle!");
            }
            else
            {   
                Console.WriteLine("Invalid choice. YOU IDIOT!");
            }

        }
    }
}
