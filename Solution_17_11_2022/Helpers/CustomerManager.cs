using Solution_16_11_2022.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Solution_17_11_2022.Helpers
{
    internal class CustomerManager
    {
        public Customer[] ArrayOfCustomers { get; set; } // this is only visible from each object of the class
      
        public CustomerManager(Customer[] customers) 
        { 
            ArrayOfCustomers = customers;
        }

        public static Customer CreateCustomerFromUI()
        {
            // Id, FirstName, LastName, Email, Mobile, DateOfBirth
            int id = ConsolePrompt.GetPropertyAsInt("Id");
            string firstName = ConsolePrompt.GetPropertyAsString("First Name");
            string lastName = ConsolePrompt.GetPropertyAsString("Last Name");
            string email = ConsolePrompt.GetPropertyAsString("Email");
            string mobile = ConsolePrompt.GetPropertyAsString("Mobile");
            DateTime dateOfBirth = ConsolePrompt.GetPropertyAsDateTime("Date Of Birth");
            Customer c = new Customer(id, firstName, lastName, email, mobile, dateOfBirth);
            return c;
        }
        
        // public static Customer CreateCustomerWithRandomData()
        
        // ζητάει από το πληκτρολόγιο αριθμό των Customers που θέλουμε να καταχωρήσουμε
        // και θα τους καταχωρεί σε ένα arrayOfCustomers

        public static Customer[] CreateCustomersArrayFromUI()
        {
            int noOfCustomers = ConsolePrompt.GetPropertyAsInt("number of customers you would like to add");
            Customer[] arrayOfCustomers = new Customer[noOfCustomers];
            for (int i = 0; i < noOfCustomers; i++)
            {
                Console.WriteLine($"Please type the details of the Customer {i + 1}");
                arrayOfCustomers[i] = CreateCustomerFromUI();
                Console.WriteLine();
            }
            return arrayOfCustomers;
        }

        // public static Customer[] CreateCustomersArrayWithRandomData()

        public void PrintCustomersArray()
        {
            foreach (var customer in ArrayOfCustomers)
            {
                Console.WriteLine(customer);
            }
        }

    }
}
