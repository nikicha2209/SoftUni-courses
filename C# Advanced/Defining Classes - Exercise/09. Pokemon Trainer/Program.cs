namespace _09._Pokemon_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>(); 
            string line = string.Empty;
            while((line = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer currentTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);
                if(currentTrainer == null)
                {
                    List<Pokemon> pokemons = new List<Pokemon>();
                    pokemons.Add(pokemon);
                    Trainer trainer = new Trainer(trainerName, 0, pokemons);
                    trainers.Add(trainer);
                }

                else
                {
                    currentTrainer.Pokemons.Add(pokemon);
                }
            }

            string element = string.Empty;
            while((element = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    trainer.CheckPokemon(element);
                }
            }

            foreach (Trainer trainer in trainers.OrderByDescending(t=> t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}