using Solution_16_11_2022.Models;
using System;
using System.Net.Http.Headers;

namespace Solution_16_11_2022.Helpers
{
    internal class ProductManager
    {

        public static Product[] CreateProductsFromUI(int noProducts)
        {
            int noOfProducts = noProducts;
            Product[] products = new Product[noOfProducts];
            for (int i = 0; i < noOfProducts; i++)
            {
                products[i] = new Product(ConsolePrompt.GetPropertyAsInt("Id"),
                ConsolePrompt.GetPropertyAsString("Title"), ConsolePrompt.GetPropertyAsString("Description"),
                ConsolePrompt.GetPropertyAsDouble("Price"), ConsolePrompt.GetPropertyAsString("Serial Number"));
            }

            return products;
        }

        // dummy data or synthetic data
        public static Product[] CreateProductsWithRandomData(int noProducts)
        {
            // Step 1. create an array of Product with noProducts places
            Product[] arrayOfProducts = new Product[noProducts]; // δημιουργεί έναν πίνακα με άδειο περιεχόμενο
            
            // Step 2. for loop for the length of the array 
            for(int i = 0; i < arrayOfProducts.Length; i++) 
            {
                // Step 3. initialize this position of the array with random data
                arrayOfProducts[i] = new Product(RandomGenerator.GenerateInteger(999999), RandomGenerator.GenerateString(5), RandomGenerator.GenerateString(12), RandomGenerator.GenerateDouble(1000), RandomGenerator.GenerateString(20, true));
            }
            
            // Step 4. return the filled arrayOfProducts
            return arrayOfProducts;
        }
    }
}