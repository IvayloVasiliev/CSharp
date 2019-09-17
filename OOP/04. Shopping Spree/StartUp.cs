using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).Select(CreatePerson).ToList();
            List<Product> products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).Select(CreateProduct).ToList();

            List<string> data = Console.ReadLine().Split(' ').ToList();

            while (data[0] != "END")
            {
                string name = data[0];
                string product = data[1];

                Person currentPerson = people.Where(p => p.PersonName == name).First();
                Product currentProduct = products.Where(p => p.ProductName == product).First();

                currentPerson.Buy(currentProduct);

                data = Console.ReadLine().Split(' ').ToList();
            }

            foreach (Person person in people)
            {
                if (person.GetProductsNames().Count == 0)
                {
                    Console.WriteLine($"{person.PersonName} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.PersonName} - {string.Join(", ", person.GetProductsNames())}");
                }
               
            }

        }

        static Person CreatePerson(string personData)
        {
            string name = personData.Split('=').ToList()[0];
            decimal money = decimal.Parse(personData.Split('=').ToList()[1]);
            Person person = new Person(name, money);
            return person;
        }

        static Product CreateProduct(string productData)
        {
            List<string> data = productData.Split('=').ToList();
            string name = data[0];
            decimal cost = decimal.Parse(data[1]);
            Product product = new Product(name, cost);
            return product;
        }

    }
}
