using Solution_16_11_2022.Helpers;
using Solution_16_11_2022.Models;
using Solution_17_11_2022.Helpers;
using Solution_17_11_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Solution_17_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateSomeProducts();
            //CreateCustomers();

            // creates a new human object
            Human human = new Human(0, "g", "p", "p@p", "6977", new DateTime(1,1,1));
            Console.WriteLine(human);

            // creates a new employee
            Employee employee = new Employee(0, "G", "P", "p@p", "6977", 
                new DateTime(1,1,1), 200);

            // creates 40 employees
            Employee[] employees = new Employee[1];
            for(int i = 0; i < 1; i++)
            {
                employees[i] = new Employee();
            }
            Console.WriteLine(employees[0]);

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
