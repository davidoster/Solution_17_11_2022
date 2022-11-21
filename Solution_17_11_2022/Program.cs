using ConsoleTools;
using Solution_16_11_2022.Helpers;
using Solution_16_11_2022.Models;
using Solution_17_11_2022.Helpers;
using System;
using System.Collections.Generic;

namespace Solution_17_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // => lambda expression
            // Action

            //ConsoleMenu.Menu menu1 = new ConsoleMenu.Menu();

            //CreateSomeProducts();
            //CreateCustomers();

            // creates a new human object
            //Human human = new Human(0, "g", "p", "p@p", "6977", new DateTime(1, 1, 1));
            //Console.WriteLine(human);

            // creates a new employee
            //Employee employee = new Employee(0, "G", "P", "p@p", "6977",
            //    new DateTime(1, 1, 1), 200);

            // creates 40 employees
            //Employee[] employees = new Employee[40];
            //for (int i = 0; i < 40; i++)
            //{
            //    employees[i] = new Employee();
            //}
            //Console.WriteLine(employees[0]);

            // array initializer with brackets - bracket initializer
            //Customer[] customers = new Customer[3]
            //{
            //    new Customer(),  // customers[0]
            //    new Customer(),  // customers[1]
            //    new Customer()   // customers[2]
            //};

            // store to a list a number of customers(4), then ask the user to add 3 more customers
            //List<Customer> listOfCustomers = new List<Customer>();
            //Customer c = new Customer(100, "fname", "lname", "email", "6999", new DateTime(1,1,1));
            //for(int i = 0; i < 20; i++)
            //{
            //    listOfCustomers.Add(new Customer());
            //}
            //listOfCustomers.Add(c); // index == 20
            //Console.WriteLine(listOfCustomers.Count);
            //Console.WriteLine(listOfCustomers[listOfCustomers.Count - 1]);
            //Console.WriteLine(listOfCustomers.Capacity);
            //listOfCustomers.Remove(listOfCustomers[4]);
            //Console.WriteLine(listOfCustomers.Count);
            //Console.WriteLine(listOfCustomers.Capacity);


            // 1. create 3 products with random data
            // 2. store the 3 products to a list
            // 3. the product at index 1 must have Id = 200
            // 4. do a for loop and find the product with Id 200 and remove it from this index

            // 1
            //List<Product> products = new List<Product>();
            // 2
            //for(int i = 0; i < 3; i++)
            //{
            //    products.Add(ProductManager.CreateProductWithRandomData());
            //}
            // 3
            //products[1].Id = 200; 
            // 4 - Searching product Id == 200
            //for(int i = 0; i < products.Count; i++)
            //{
            //    if (products[i].Id == 200) 
            //    {
            //        Console.WriteLine($"The product with Id = 200 was found at {i}");
            //        products.RemoveAt(i);
            //        break;
            //    }
            //}

            // 4. Alternative way to search
            //products.Remove(products.Find(product => product.Id == 200));
            //Console.WriteLine(products[1]);

            //string[] options = new string[]
            //{
            //    "1. Create Product", // ProductManager.CreateProductFromUI 0
            //    "2. Create Customer", // CustomerManager.CreateCustomerFromUI 1
            //    "3. View Product", // ... 2
            //    "4. View Customer", // ... 3
            //    "5. Exit"
            //};
            //Menu menu = new Menu(options, listOfCustomers);

            Customer customer = new Customer(1,"George", "Paspa", "paspa@paspa", "6977", DateTime.Now);
            List<Product> products = new List<Product>()
            {
                ProductManager.CreateProductWithRandomData()
            };
            products.Add(ProductManager.CreateProductWithRandomData());
            products.Add(ProductManager.CreateProductWithRandomData());
            Order order = new Order(1, "sdsfsdf", DateTime.Now, customer, products);
            Console.WriteLine(order);

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        }

        private static void CreateCustomers()
        {
            Customer[] customers2021 = CustomerManager.CreateCustomersArrayFromUI(); // customers 2021
            Customer[] customers2022 = CustomerManager.CreateCustomersArrayFromUI(); // customers 2022

            CustomerManager customerManager2021 = new CustomerManager(customers2021);
            customerManager2021.PrintCustomersArray();

            CustomerManager customerManager2022 = new CustomerManager(customers2022);
            customerManager2022.PrintCustomersArray();

            Console.WriteLine(customerManager2022.ArrayOfCustomers[0]);
        }

        private static void CreateSomeProducts()
        {
            Product[] arrayOfProducts = new Product[4];
            arrayOfProducts = ProductManager.CreateProductsWithRandomData(2);
            foreach (Product product in arrayOfProducts)
            {
                Console.WriteLine(product);
            }

            arrayOfProducts = ProductManager.CreateProductsFromUI(2);
        }
    }

    struct SomeStruct
    {
        public int Id;


        public SomeStruct(int id)
        {
            Id = id + 5;
        }
    }
}
