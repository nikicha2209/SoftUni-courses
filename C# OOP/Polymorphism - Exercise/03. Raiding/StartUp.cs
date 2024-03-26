using _03._Raiding.Heroes;

namespace _03._Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();

            while(heroes.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    BaseHero hero = HeroFactory.GetHero(name, type);
                    heroes.Add(hero);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (BaseHero hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int raidPower = heroes.Select(h => h.Power).Sum();
            Console.WriteLine(raidPower >= bossPower ? "Victory!" : "Defeat...");
        }
    }
}