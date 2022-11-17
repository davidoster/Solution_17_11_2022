using Solution_16_11_2022.Helpers;
using Solution_16_11_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_17_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] arrayOfProducts = new Product[4];
            arrayOfProducts = ProductManager.CreateProductsWithRandomData(2);
            foreach (Product product in arrayOfProducts) //arrayOfProducts[0]
            {
                Console.WriteLine(product);
            }

            arrayOfProducts = ProductManager.CreateProductsFromUI(2);

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
