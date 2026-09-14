namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Litter light in the dark===");
            Console.WriteLine();
            Console.WriteLine("Hero VS Monster -- Battle Begins!");
            Console.WriteLine();
            Console.Write("Hero Heal :");
            bool isHeroHeal = int.TryParse(Console.ReadLine(), out int heroHealth);
            Console.WriteLine();
            Console.Write("Hero Attack :");
            bool isHeroAttack = int.TryParse(Console.ReadLine(), out int heroAttack);
            Console.WriteLine();
            Console.Write("Hero Defense :");
            bool isHeroDefense = int.TryParse(Console.ReadLine(), out int heroDefense);
            Console.WriteLine();
            Console.Write("Monster Heal :");
            bool isMonsterHeal = int.TryParse(Console.ReadLine(), out int monsterHealth);   
            Console.WriteLine();
            Console.Write("Monster Attack :");
            bool isMonsterAttack = int.TryParse(Console.ReadLine(), out int monsterAttack);
            Console.WriteLine();
            Console.Write("Monster Defense :");
            bool isMonsterDefense = int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine();
            bool allHeroStatsValid = isHeroHeal && isHeroAttack && isHeroDefense;
            bool allMonsterStatsValid = isMonsterHeal && isMonsterAttack && isMonsterDefense;
            Console.WriteLine($"Stats Salidation Hero : {allHeroStatsValid} Monster : {allMonsterStatsValid}");
            Console.WriteLine();
            Console.WriteLine($"[HERO] HP: {heroHealth} ATK: {heroAttack} DEF: {heroDefense}");
            Console.WriteLine();
            Console.WriteLine($"[MONSTER] HP: {monsterHealth} ATK: {monsterAttack} DEF: {monsterDefense}");
            Console.WriteLine();
            int PotionHeal = 8;
            heroHealth += PotionHeal;
            Console.WriteLine($"\n => Hero drink a Potion, Healing {PotionHeal} HP. health is now : {heroHealth}");
            Console.WriteLine();
            int normalDamage = Math.Max(0, heroAttack - monsterDefense);
            Console.WriteLine($"Normal attack deals {normalDamage} DMG.");
            Console.WriteLine();
            int powerAttackDamage = Math.Max(0, heroAttack * 2 - monsterDefense);
            Console.WriteLine($"Power attack deals {powerAttackDamage} DMG.");
            Console.WriteLine();
            int counterDamage = Math.Max(0, monsterAttack - heroDefense);
            Console.WriteLine($"MonsterCounter attack deals {counterDamage} DMG.");
            Console.WriteLine();
            Random rng = new Random();
            int roll = rng.Next(1, 21);
            bool isCrit = roll >= 10;
            var critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage;
            Console.WriteLine($"Critical hit roll : {roll} (critical : {isCrit})");
            Console.WriteLine($"Normal attack would deal critical : {critDamage} DMG.");







        }
    }
}
