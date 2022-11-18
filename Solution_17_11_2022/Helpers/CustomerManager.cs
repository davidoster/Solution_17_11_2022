using Solution_16_11_2022.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_17_11_2022.Helpers
{
    internal class CustomerManager
    {
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

        // ζητάει από το πληκτρολόγιο αριθμό των Customers που θέλουμε να καταχωρήσουμε
        // και θα τους καταχωρεί σε ένα arrayOfCustomers
    }
}
