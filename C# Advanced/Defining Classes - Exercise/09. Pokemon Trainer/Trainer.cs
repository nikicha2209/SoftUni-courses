using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Pokemon_Trainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemons)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
            Pokemons = pokemons;
        }

        public void CheckPokemon(string element)
        {
            if (Pokemons.Any(p => p.Element == element))
            {
                NumberOfBadges++;
            }

            else
            {
                for (int i = 0; i < Pokemons.Count; i++)
                {
                    Pokemons[i].Health -= 10;
                    if (Pokemons[i].Health <= 0)
                    {
                        Pokemons.Remove(Pokemons[i]);
                        
                    }

                }
            }
        }
    }
}
