using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        //name, element and health
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;              
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }


        public string Element
        {
            get { return element; }
            set { element = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void ReduceHealth()
        {
            Health -= 10;
        }

    }
}
