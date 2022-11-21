using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Menu
    {
        string[] Options = new string[]
        {
            "1. Create Product",
            "2. Create Customer",
            "3. View Product",
            "4. View Customer",
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
                switch (userOption.Key)
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
                }
                Console.Clear();
            }
        }
    }
}
