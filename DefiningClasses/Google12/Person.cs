using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private class Company
        {
            private string companyName;
            private string department;
            private decimal salary;

            public Company(string companyName, string department, decimal salary)
            {
                this.companyName = companyName;
                this.department = department;
                this.salary = salary;
            }

            public override string ToString()
            {
                return $"{companyName} {department} {salary:F2}";
            }
        }

        private class Pokemon
        {
            private string name;
            private string type;

            public Pokemon(string name, string type)
            {
                this.name = name;
                this.type = type;
            }

            public override string ToString()
            {
                return $"{name} {type}";
            }
        }

        private class Car
        {
            private string model;
            private int speed;

            public Car(string model, int speed)
            {
                this.model = model;
                this.speed = speed;
            }

            public override string ToString()
            {
                return $"{model} {speed}";
            }
        }

        private string name;
        private List<Person> parents;
        private List<Person> children;
        private List<Pokemon> pokemons;
        private Car car;
        private Company company;
        string birthday;

        public Person(string name, string birthday = null)
        {
            this.name = name;
            this.birthday = birthday;
            this.parents = new List<Person>();
            this.children = new List<Person>();
            this.pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public void AddParent(Person parent)
        {
            parents.Add(parent);
        }

        public void AddChild(Person child)
        {
            children.Add(child);
        }
        
        public void AddPokemon(string name, string type)
        {
            pokemons.Add(new Pokemon(name, type));
        }

        public void AssignCompany(string companyName, string department, decimal salary)
        {
            company = new Company(companyName, department, salary);
        }

        public void AssignCar(string model, int speed)
        {
            car = new Car(model, speed);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(this.name);
            builder.AppendLine("Company:");

            if (company != null)
            {
                builder.AppendLine(company.ToString());
            }

            builder.AppendLine("Car:");

            if (this.car != null)
            {
                builder.AppendLine(car.ToString());
            }

            builder.AppendLine("Pokemon:");

            foreach (var pokemon in pokemons)
            {
                builder.AppendLine(pokemon.ToString());
            }

            builder.AppendLine("Parents:");

            foreach (var parent in parents)
            {
                builder.AppendLine($"{parent.name} {parent.birthday}");
            }

            builder.AppendLine("Children:");

            foreach (var child in children)
            {
                builder.AppendLine($"{child.name} {child.birthday}");
            }

            return builder.ToString();
        }


    }
}
