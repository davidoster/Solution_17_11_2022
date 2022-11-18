using Solution_16_11_2022.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_17_11_2022.Models
{
    internal class Employee : Human // : Human ----> inherits the Human properties and methods - Single inheritance classes
        // multiple inheritance interfaces
    {
        public Employee(int id, string firstName, string lastName, 
            string email, string mobile, DateTime dateOfBirth, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Mobile = mobile;
            DateOfBirth = dateOfBirth;
            Salary = salary;
        }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\tSalary: {Salary}";
        }
    }
}
