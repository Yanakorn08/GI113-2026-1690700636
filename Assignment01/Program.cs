/*
 * Student ID : 1690700636
 * Name       : Yanakorn Rodclom
 * Section    : 129A
 * No.        : 26
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slayer = "Benvolio";
            var weaponUsing = "Sword";
            char gender = 'M';
            int smallEnemyDamage = 22;
            var giantsEnemyDamage = 22;
            var bossDamage = 8;
            float coinPerSecond = 23.2f;
            double criticalDemage = 32.6;
            bool isSlayer = true;
            const string Weapon = "Sword";
            
            Console.WriteLine($"+-----------------------------------------------------------+");
            Console.WriteLine($"|                                                           |");
            Console.WriteLine($"| ___  ____     ____        _____                ____ _____ |");
            Console.WriteLine($"|  |  |   | |   |           |      |     /|  | / |    |___| |");
            Console.WriteLine($"|  |  |   | |   |--         |----| |    /_|  |/  |--  | |   |");
            Console.WriteLine($"| _|_ |__/  |__ |___        _____| |__ /  |  |   |___ |  |  |");
            Console.WriteLine($"|                                                           |");
            Console.WriteLine($"+-----------------------------------------------------------+");
            Console.WriteLine();
            Console.WriteLine($"Slayer Name : {slayer}");
            Console.WriteLine($"Weapon : {weaponUsing}");
            Console.WriteLine($"Gender : {gender}");
            Console.WriteLine($"Small Enemy Damage : {smallEnemyDamage}");
            Console.WriteLine($"Giant Enemy Damage : {giantsEnemyDamage}");
            Console.WriteLine($"Boss Damage : {bossDamage}");
            Console.WriteLine($"Coins Per Second : {coinPerSecond}");
            Console.WriteLine($"Critical Damage : {criticalDemage}");
            Console.WriteLine($"Is Slayer : {isSlayer}");
            Console.WriteLine($"Weapon : {Weapon}");
            Console.WriteLine();
            double giantEnemyDamageDouble = giantsEnemyDamage;
            Console.WriteLine($"Giant Enemy Damage (Double) : {giantEnemyDamageDouble}");
            Console.WriteLine();
            int criticalDamageBoxBoost = (int)criticalDemage;
            int criticalDamageSkillBoost = Convert.ToInt32(criticalDemage);
            Console.WriteLine($"Critical Damage (Int) : {criticalDamageBoxBoost}");
            Console.WriteLine($"Boss Damage (Int) : {criticalDamageSkillBoost}");
        }
    }
}
