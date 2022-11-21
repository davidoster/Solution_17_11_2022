using Solution_16_11_2022.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Solution_17_11_2022.Helpers
{
    internal class Menu
    {
        public string[] Options { get; set; } = new string[]
        {
            "1. Create Product", // ProductManager.CreateProductFromUI 0
            "2. Create Customer", // CustomerManager.CreateCustomerFromUI 1
            "3. View Product", // ... 2
            "4. View Customer", // ... 3
            "5. Exit"
        };

        public Menu()
        {
            bool stop = false;
            while (!stop)
            {
                foreach (var menuOption in Options)
                {
                    Console.WriteLine(menuOption);
                }
                ConsoleKeyInfo userOption = Console.ReadKey();
                switch (userOption.Key) // char, int, enum
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nCreate Product");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nCreate Customer");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nView Product");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nView Customer");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("\nTerminating application");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("\nPlease select one of the keys 1 - 5");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }

        public Menu(string[] options, List<Customer> customers)
        {
            Options = options;
            bool stop = false;
            while (!stop)
            {
                foreach (var menuOption in Options)
                {
                    Console.WriteLine(menuOption);
                }
                ConsoleKeyInfo userOption = Console.ReadKey();
                switch (userOption.Key) // char, int, enum
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nCreate Product");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nCreate Customer");
                        Customer customer = CustomerManager.CreateCustomerFromUI();
                        customers.Add(customer);
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nView Product");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nView Customer");
                        Console.WriteLine(customers[0]);
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("\nTerminating application");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("\nPlease select one of the keys 1 - 5");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
