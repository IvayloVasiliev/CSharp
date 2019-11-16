using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        //name, number of badges and a collection of pokemon
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            Name = name;
            this.Pokemons = new List<Pokemon>();
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }


        public int NumberOfBadges
        {
            get { return numberOfBadges; }
            set { numberOfBadges = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        public void IncreaseBadges()
        {
            NumberOfBadges ++;
        }

        public void ReducePokemonsHealth()
        {
            Pokemons.ForEach(p => p.ReduceHealth());
        }

        public void RemoveDead()
        {
            this.Pokemons = this.Pokemons
                .Where(p => p.Health > 0)
                .ToList();
        }

        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {Pokemons.Count}";
        }


    }
}
