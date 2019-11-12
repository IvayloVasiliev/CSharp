using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;


        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(int age, string name) : this(age)
        {
            this.Name = name;
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 ||  value > 120)
                {
                    throw new Exception("Not an age");
                }
                this.age = value;
            }
        }

             public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
}
