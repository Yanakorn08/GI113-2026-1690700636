/*
 * Student ID : 1690700636
 * Name       : Yanakorn Rodclom
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

using System.Runtime.Intrinsics.Arm;

namespace Lab3
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

            Console.WriteLine($"===== KIRIN SAVE CONVERTER ===== ");
            Console.WriteLine();
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level} / {MaxLevel}");
            Console.WriteLine($"Current HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            Console.WriteLine("----- Implicit Conversion: HP as double -----");

        }
    }
}
