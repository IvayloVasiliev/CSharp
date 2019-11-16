using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<Trainer> trainers = new List<Trainer>();

            while (data[0] != "Tournament")
            {
                string trainerName = data[0];
                string  pokemonName = data[1];
                string element = data[2];
                int health = int.Parse(data[3]);

                if (!trainers.Any(t=>t.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                Trainer trainer = trainers.First(t => t.Name == trainerName);
                trainer.AddPokemon(pokemon);

                data = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.IncreaseBadges();
                    }
                    else
                    {
                        trainer.ReducePokemonsHealth();
                        trainer.RemoveDead();
                    }
                }
            }

            trainers.OrderByDescending(t => t.NumberOfBadges)
                .ToList()
                .ForEach(Console.WriteLine);


        }
    }
}
