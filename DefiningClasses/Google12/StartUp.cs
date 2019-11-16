using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
                      
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
               var data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = data[0];
                string property = data[1];

                if (!people.Any(p => p.Name == name))
                {
                    people.Add(new Person(name));
                }

                var currentPerson = people.First(p => p.Name == name);

                switch (property)
                {
                    case "company":
                        currentPerson.AssignCompany(data[2], data[3], decimal.Parse(data[4]));
                        break;
                    case "pokemon":
                        currentPerson.AddPokemon(data[2], data[3]);
                        break;
                    case "parents":
                        string parentName = data[2];
                        currentPerson.AddParent(new Person(parentName, data[3]));
                        break;
                    case "children":
                        string childName = data[2];
                        currentPerson.AddChild(new Person(childName, data[3]));
                        break;
                    case "car":
                        currentPerson.AssignCar(data[2], int.Parse(data[3]));
                        break;

                    default:
                        throw new Exception();
                }
            }

            command = Console.ReadLine();

            Person result = people.First(p => p.Name == command);
            Console.WriteLine(result);

        }
    }
}
