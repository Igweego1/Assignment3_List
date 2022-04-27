using System;
using System.Collections.Generic;


namespace Assignment3
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //LIST OF PRODUCTS

            List<Product> list = new List<Product>()
            {
                new Product() { Name = "Toblerone Chocolate", Quantity = 10},
                new Product() { Name = "Indomie Noodles" , Quantity = 50},
                new Product() { Name = "Corn Flakes",     Quantity = 5},
                new Product() { Name = "washing Soap",    Quantity = 75},
                new Product() { Name = "Bag of Rice",     Quantity = 15},
                new Product() { Name = "Bottle Water",    Quantity = 23},
                new Product() { Name = "Perfume Deodorant",Quantity = 30},
                new Product() { Name = "Golden Morn",      Quantity = 6},
                new Product() { Name = "Tooth Paste",      Quantity = 90},
                new Product() { Name = "Hand sanitizer",  Quantity = 100},

            };

            //BEFORE SORTING

            Console.WriteLine("BEFORE SORTING");
            
            foreach (Product p in list)
            {

                Console.WriteLine("{0} {1}", p.Name, p.Quantity);

            }

            Console.WriteLine();

            //SORT

            list.Sort(new SortProduct());
            Console.WriteLine("AFTER SORTING");
            
            foreach (var p in list)
            {

                Console.WriteLine("{0} {1}", p.Name, p.Quantity);
            }
        }
    }

    //PRODUCTS
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}, Quantity: {Quantity}";
        }
    }

    //CLASS TO HELP SORT IN DESCENDING ORDER

    public class SortProduct : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.Quantity < y.Quantity)
            {
                return 1;
            }
            else if (x.Quantity > y.Quantity)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }




}
