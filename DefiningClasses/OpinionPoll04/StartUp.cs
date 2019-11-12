﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(age, name);
                family.AddMember(person);
            }

            var oldestMembers = family.GetOldestMember();
            foreach (var person in oldestMembers)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            
        }
    }
}
