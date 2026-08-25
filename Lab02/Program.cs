/*
 * Student ID : 1690700636
 * Name       : Yanakorn Rodclom
 * Section    : 129A
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boss Status
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // Party Hero Status
            string heroName1 = "Mont Blanc D Noland";
            string heroClass1 = "Cleric";
            char heroRank1 = 'C';
            int heroLevel1 = 15;
            int heroMaxHp1 = 70;
            int heroCurrentHp1 = 70;
            float heroAttackPower1 = 15.2f;
            double heroCritMultiplier1 = 1.6;
            bool isHero1 = true;

            string heroName2 = "John Berg";
            string heroClass2 = "Fighter";
            char heroRank2 = 'C';
            int heroLevel2 = 17;
            int heroMaxHp2 = 110;
            int heroCurrentHp2 = 110;
            float heroAttackPower2 = 15.2f;
            double heroCritMultiplier2 = 1.1;
            bool isHero2 = true;

            string heroName3 = "Nero Dread Sovereign";
            string heroClass3 = "Sorcerer";
            char heroRank3 = 'C';
            int heroLevel3 = 11;
            int heroMaxHp3 = 60;
            int heroCurrentHp3 = 60;
            float heroAttackPower3 = 15.2f;
            double heroCritMultiplier3 = 0.0;
            bool isHero3 = true;

            string heroName4 = "Dargro";
            string heroClass4 = "Druid";
            char heroRank4 = 'B';
            int heroLevel4 = 17;
            int heroMaxHp4 = 150;
            int heroCurrentHp4 = 150;
            float heroAttackPower4 = 15.2f;
            double heroCritMultiplier4 = 1.2;
            bool isHero4 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine();
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine(currentHp = currentHp - 60);
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine();
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            int HP = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {HP}%");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===== PARTY HERO STATUS: INITIAL =====");
            Console.WriteLine();
            Console.WriteLine($"Name: {heroName1}");
            Console.WriteLine($"Class: {heroClass1}");
            Console.WriteLine($"Rank: {heroRank1}");
            Console.WriteLine($"Level: {heroLevel1}");
            Console.WriteLine($"Max HP: {heroMaxHp1}");
            Console.WriteLine($"Current HP: {heroCurrentHp1}");
            Console.WriteLine($"Attack Power: {heroAttackPower1}");
            Console.WriteLine($"Critical Multiplier: {heroCritMultiplier1}");
            Console.WriteLine($"Is Hero: {isHero1}");
            Console.WriteLine();
            Console.WriteLine($"Name: {heroName2}");
            Console.WriteLine($"Class: {heroClass2}");
            Console.WriteLine($"Rank: {heroRank2}");
            Console.WriteLine($"Level: {heroLevel2}");
            Console.WriteLine($"Max HP: {heroMaxHp2}");
            Console.WriteLine($"Current HP: {heroCurrentHp2}");
            Console.WriteLine($"Attack Power: {heroAttackPower2}");
            Console.WriteLine($"Critical Multiplier: {heroCritMultiplier2}");
            Console.WriteLine($"Is Hero: {isHero2}");
            Console.WriteLine();
            Console.WriteLine($"Name: {heroName3}");
            Console.WriteLine($"Class: {heroClass3}");
            Console.WriteLine($"Rank: {heroRank3}");
            Console.WriteLine($"Level: {heroLevel3}");
            Console.WriteLine($"Max HP: {heroMaxHp3}");
            Console.WriteLine($"Current HP: {heroCurrentHp3}");
            Console.WriteLine($"Attack Power: {heroAttackPower3}");
            Console.WriteLine($"Critical Multiplier: {heroCritMultiplier3}");
            Console.WriteLine($"Is Hero: {isHero3}");
            Console.WriteLine();
            Console.WriteLine($"Name: {heroName4}");
            Console.WriteLine($"Class: {heroClass4}");
            Console.WriteLine($"Rank: {heroRank4}");
            Console.WriteLine($"Level: {heroLevel4}");
            Console.WriteLine($"Max HP: {heroMaxHp4}");
            Console.WriteLine($"Current HP: {heroCurrentHp4}");
            Console.WriteLine($"Attack Power: {heroAttackPower4}");
            Console.WriteLine($"Critical Multiplier: {heroCritMultiplier4}");
            Console.WriteLine($"Is Hero: {isHero4}");
        }
    }
}
