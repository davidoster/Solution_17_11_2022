using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal class ConsolePrompt
    {
        // al the methods below are accessible via the name of the class
        // (and not from a class object of type ConsolePrompt)
        public static string GetPropertyAsString(string name)
        {
            Console.WriteLine($"Please type the {name}: ");
            return Console.ReadLine();
        }

        public static int GetPropertyAsInt(string name)
        {
            Console.WriteLine($"Please type the {name}: ");
            return int.Parse(Console.ReadLine());
        }

        public static double GetPropertyAsDouble(string name)
        {
            Console.WriteLine($"Please type the {name}: ");
            return double.Parse(Console.ReadLine());
        }

        public static DateTime GetPropertyAsDateTime(string name)
        {
            Console.WriteLine($"Please type the {name}: ");
            return DateTime.Parse(Console.ReadLine());
        }
    }
}
