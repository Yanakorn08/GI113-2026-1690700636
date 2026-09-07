/*
 * Student ID : 1690700636
 * Name       : Yanakorn Rodclom
 * Section    : 129A
 * No.        : 26
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine();
            Console.WriteLine($"\nBoss Name: {bossName} \nRank: {rank} \nLevel: {level}/{MaxLevel} \nHP: {currentHp}/{maxHp} \nAttack Power: {attackPower} \nCritical Multiplier: {critMultiplier} \nIs Boss: {isBoss}");
            Console.WriteLine();
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            Console.WriteLine();
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");
            Console.WriteLine();

            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            Console.WriteLine();
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");
            Console.WriteLine();

            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            Console.WriteLine();
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");
            Console.WriteLine();

            Console.WriteLine("-----Cast vs Convert: Crit Multiplier-----");
            Console.WriteLine();
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int cast): {critCast}");
            Console.WriteLine($"Critical Multiplier (Convert.ToInt32): {critConvert}");
            Console.WriteLine();

        }
    }
}
