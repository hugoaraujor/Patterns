using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp5
{
    class Program
    {

        public interface IProduct
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            void getComponents();

        }

            public class Product : IProduct
            {
          
            public string ProductName { get; set;}
            public decimal Price { get; set; }

            public Product(string product, decimal price)
            {
                this.ProductName = product;
                this.Price = price;
          

            }
            void IProduct.getComponents()
            {
                Console.WriteLine("Product {0} Price {1}", ProductName, Price);
            }
            }


        public class Kit : IProduct
        {
           public List<IProduct> ComponentsList;
            public string ProductName { get; set; }
            public decimal Price { get; set; }

            public Kit(string product, decimal price)
            {
                this.ProductName = product;
                this.Price = price;
                ComponentsList = new List<IProduct>();

            }
            void IProduct.getComponents()
            {
                foreach (var product in ComponentsList)
                {
                    product.getComponents();
                }
            }
        }

        static void Main(string[] args)
            {
            IProduct Coke = new Product("Coke", 23.50M);
            Coke.getComponents();
            IProduct Fries = new Product("Fries", 35.50M);
            IProduct Burguer = new Product("Especial Burguer", 65.50M);
            IProduct Combo = new Kit("Basic Combo", 100M)
            {
                ComponentsList = { Coke, Fries, Burguer }
            };
            Console.WriteLine(Combo.ProductName);
            Combo.getComponents();
            Console.WriteLine("Promo $ {0}",Combo.Price);

        }
        }
    }

