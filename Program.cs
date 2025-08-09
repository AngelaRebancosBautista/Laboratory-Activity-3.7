using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>
        {
            "Smart Tv",
            "Laptop",
            "Smartphone",
            "Headphones",
            "Smart Watch",
            "Wireless Earbuds",
            "Bluetooth Speaker",
            "Ipad",
            "Shampoo",
            "Conditioner",
            "Diatabs"
        };
            Console.WriteLine("Available Products");
            foreach (string product in products)
            {
                Console.WriteLine($"- {product}");
            }
            Console.WriteLine("\nEnter a keyword to search for products:");
            string keyword = Console.ReadLine();

            List<string> matchingProducts = new List<string>();

            foreach (string product in products)
            {
                if (product.ToLower().Contains(keyword.ToLower()))
                {
                    matchingProducts.Add(product);
                }
            }
            Console.WriteLine("\nSearch Results");
            if (matchingProducts.Count > 0)
            {
                foreach (string product in matchingProducts)
                {
                    Console.WriteLine($"- {product}");
                }
            }
            else
            {
                Console.WriteLine("No products found.");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
            
        

    
