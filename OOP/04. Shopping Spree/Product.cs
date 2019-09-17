using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingSpree
{
    class Product
    {
        private string productName;
        private decimal productCost;

        public Product(string productName, decimal productCost)
        {
            this.ProductName = productName;
            this.ProductCost = productCost;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if (value == string.Empty || string.IsNullOrWhiteSpace(value) )
                {
                    Console.WriteLine("Name cannot be empty");
                    Environment.Exit(0);
                }
                this.productName = value;
            }
        }

        public decimal ProductCost
        {
            get
            {
                return this.productCost;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }
                this.productCost = value;
            }
        }



    }
}
