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
            //Step 1.Ask from the user to type an input
            // Step 2. Store the input to a string variable
            // Step 3. Convert the value of the variable to the appropriate type
            //Console.WriteLine("Please type the Id: ");
            //string id = Console.ReadLine();
            //int iId = Convert.ToInt16(id);

            // Step 4. Create as many methods as required to get the different types (AsString, AsInt, AsDouble)
            // do the method(s)

            //Product myProduct = new Product(GetPropertyAsInt("Id"), GetPropertyAsString("Title"), 
            //                                GetPropertyAsString("Description"), GetPropertyAsDouble("Price"), 
            //                                GetPropertyAsString("Serial Number"));
            //Console.WriteLine(myProduct);

            // Step 5. Moved these methods to their own class called ConsolePrompt
            //Product myProduct2 = new Product(ConsolePrompt.GetPropertyAsInt("Id"), 
            //    ConsolePrompt.GetPropertyAsString("Title"), ConsolePrompt.GetPropertyAsString("Description"),
            //    ConsolePrompt.GetPropertyAsDouble("Price"), ConsolePrompt.GetPropertyAsString("Serial Number"));

            //int[] array = new int[2];
            //array[0] = 1;
            //array[1] = 2;
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array.Length);


            //Product[] products = ProductManager.CreateProductsFromUI(2);

            //// print array of products
            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine(products[i]);
            //}
            Product[] arrayOfProducts = ProductManager.CreateProductsWithRandomData(0);
            foreach (Product product in arrayOfProducts)
            {
                Console.WriteLine(product);
            }

            char a = '0';
            int asciiA = Convert.ToInt16(a);
            int asciiA32 = Convert.ToInt32(a);
            //int asciiA64 = Convert.ToInt64(a); // why the heck this does not work????

            Console.WriteLine(a);
            Console.WriteLine(asciiA);
            
            Console.WriteLine(Char.IsLetter(a));
            

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
