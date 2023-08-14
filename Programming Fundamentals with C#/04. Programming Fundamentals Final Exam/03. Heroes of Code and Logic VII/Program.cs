using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstLine = string.Empty;
            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < n; i++)
            {
                firstLine = Console.ReadLine();
                string[] tokens = firstLine.Split();
                Hero hero = new Hero(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]));
                heroes.Add(hero);

            }

            string secondLine = string.Empty;

            while ((secondLine = Console.ReadLine()) != "End")
            {
                string[] tokens = secondLine.Split(" - ");
                string command = tokens[0];
                string heroName = tokens[1];

                Hero currentHero = heroes.Find(x => heroName == x.Name);

                if (command == "CastSpell")
                {
                    int mp = int.Parse(tokens[2]);
                    string spellName = tokens[3];

                    if (currentHero.MP >= mp)
                    {
                        currentHero.MP -= mp;
                        Console.WriteLine($"{currentHero.Name} has successfully cast {spellName} and now has {currentHero.MP} MP!");
                    }

                    else
                    {
                        Console.WriteLine($"{currentHero.Name} does not have enough MP to cast {spellName}!");
                    }
                }


                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];

                    currentHero.HP -= damage;
                    if (currentHero.HP > 0)
                    {
                        Console.WriteLine($"{currentHero.Name} was hit for {damage} HP by {attacker} and now has {currentHero.HP} HP left!");
                    }

                    else
                    {
                        Console.WriteLine($"{currentHero.Name} has been killed by {attacker}!");
                        heroes.Remove(currentHero);
                    }

                }

                else if (command == "Recharge")
                {
                    int previousMP = currentHero.MP;
                    int amount = int.Parse(tokens[2]);
                    int recharge = currentHero.HP - amount;
                    currentHero.MP += amount;

                    if (currentHero.MP > 200)
                    {
                        currentHero.MP = 200;
                        recharge = 200 - previousMP;
                        Console.WriteLine($"{currentHero.Name} recharged for {recharge} MP!");
                    }

                    else
                    {
                        Console.WriteLine($"{currentHero.Name} recharged for {amount} MP!");
                    }
                }

                else if (command == "Heal")
                {
                    int previousHP = currentHero.HP;
                    int amount = int.Parse(tokens[2]);
                    int heal = currentHero.HP - amount;
                    currentHero.HP += amount;

                    if (currentHero.HP > 100)
                    {
                        currentHero.HP = 100;
                        heal = 100 - previousHP;
                        Console.WriteLine($"{currentHero.Name} healed for {heal} HP!");
                    }

                    else
                    {
                        Console.WriteLine($"{currentHero.Name} healed for {amount} HP!");
                    }

                }
            }

            foreach (Hero hero in heroes)
            {
                Console.WriteLine($@"{hero.Name}
  HP: {hero.HP}
  MP: {hero.MP}");
            }
        }
    }
}
