/*
 * Student ID : 1690700636
 * Name       : Yanakorn Rodclom
 * Section    : 129A
 * No.        : 26
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OreName01 = "Mithril";
            double SmeltRate = 0.20;
            double SalvageRate = 0.40;
            int MaxBatchSize = 200;

            Console.WriteLine("+---------------------------------+");
            Console.WriteLine("| Welcome to Hephaestus's Furnace |");
            Console.WriteLine("+---------------------------------+");
            Console.WriteLine();
            Console.WriteLine($"Mithril Smelting Rate : {SmeltRate} | Salvage Rate : {SalvageRate}");
            Console.WriteLine("Key 'S' to Smelt Ore to Ingot");
            Console.WriteLine("Key 'B' to Breakdown Ingot to Ore");
            Console.WriteLine();
            Console.Write("Choose the option (S/B) : ");
            bool isValidChoice = char.TryParse(Console.ReadLine(), out char ChoiceChar);
            Console.Write("How much Mithril : ");
            bool isValidMithrilAmount = double.TryParse(Console.ReadLine(), out double MithrilAmount);
            Console.WriteLine($"Choose input : {isValidChoice}");
            Console.WriteLine($"Option : {ChoiceChar}");
            Console.WriteLine($"Mithril Amount input : {isValidMithrilAmount}");
            Console.WriteLine($"Mithril Amount : {MithrilAmount}");
            if (MithrilAmount > 4 && MithrilAmount <= 200)
            {
                if (ChoiceChar == 'S' || ChoiceChar == 's')
                {
                    Console.WriteLine($"Mithril Smelted Completes!! You got : {MithrilAmount * SmeltRate} Ingots");
                }
                else if (ChoiceChar == 'B' || ChoiceChar == 'b')
                {
                    Console.WriteLine($"Mithril Breakdown Completes!! You got : {MithrilAmount / SalvageRate} Ores");
                }
                else
                {
                    Console.WriteLine("Something is wrong. Mithril can't be smelted or breakndown.");
                    Console.WriteLine("Please choose the option again.");
                }
            }
            else
            { 
                Console.WriteLine("Something is wrong. Mithril amount must be between 5 and 200.");
                Console.WriteLine("Please choose the option again.");
            }
            
            

        }
    }
}
