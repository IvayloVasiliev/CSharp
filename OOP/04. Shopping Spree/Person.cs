using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopingSpree
{
    class Person
    {
        private string personName;
        private decimal money;
        private List<Product> products;

        public Person(string personName, decimal money)
        {
            this.PersonName = personName;
            this.Money = money;
            this.products = new List<Product>();
        }

        public void Buy(Product product)
        {
            if (this.Money >= product.ProductCost)
            {
                this.products.Add(product);
                Console.WriteLine($"{this.PersonName} bought {product.ProductName}");
                this.Money -= product.ProductCost;
            }
            else
            {
                Console.WriteLine($"{this.PersonName} can't afford {product.ProductName}");
            }
        }

        public List<string> GetProductsNames()
        {
            return this.products.Select(p => p.ProductName).ToList();
        }

        public string PersonName
        {
            get
            {
                return this.personName;
            }

            set
            {
                if (value == string.Empty || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty");
                    Environment.Exit(0);
                }
                this.personName = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if (value < 0)
                { 
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }
                this.money = value;
            }
        }
    }
}
