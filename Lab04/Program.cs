/*
 * Student ID : 1690700636
 * Name       : Yanakorn Rodclom
 * Section    : 129A
 * No.        : 26
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|                 NEW ADVERTISEMENT                |");
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine();
            Console.Write("Name your hero :");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome, {playerName}! your journey begins now.");
            //
            Console.WriteLine();
            //
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|              DIFFICULTY SELECTION                |");
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine();
            Console.Write("Choose difficulty (1-3) : ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty set to {difficulty}.");
            //
            Console.WriteLine();
            //
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|                    ITEM SHOP                     |");
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine();
            Console.Write("How many potion? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input : {isValid}");
            Console.WriteLine($"Quantity : {quantity}");
            //
            Console.WriteLine();
            //
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|                CHARACTER CREATION                |");
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine();
            Console.Write("Name your character : ");
            string charName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Choose a class (1-3) : ");
            bool classOK = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0) : ");
            bool luckOK = double.TryParse(Console.ReadLine(), out double luck);
            //
            Console.WriteLine();
            //
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("|                 RATE THIS LEVEL                  |");
            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine();
            Console.WriteLine("Rate this level (1-5) : ");
            int rating = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You rated this level {rating}.");
        }
    }
}
