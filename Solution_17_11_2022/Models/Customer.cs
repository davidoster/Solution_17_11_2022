using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_16_11_2022.Models
{
    internal class Customer
    {
        // Id, FirstName, LastName, Email, Mobile, DateOfBirth
        // get returns to the requester the value
        // set stores the value that is given
        private int _Id;
        public int Id { 
            get 
            { 
                return _Id; 
            } 
            
            private set
            {
                if (value <= 0)
                {
                    _Id = 1;
                }
                else
                {
                    _Id = value + 5000;
                }
            } 
        }

        private string _firstname;
        public string FirstName
        {
            get 
            {
                return _firstname.ToUpper();
            }
            set 
            { 
                _firstname = value;
            }
        }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public DateTime DateOfBirth { get; set; }

        
        public Customer()
        {           
            Id = -1; // 2nd
        }

        public Customer(int id)
        {
            Id = id; // 3rd
        }

        public Customer(int id, string firstName, string lastName)
        {
            Id = id + 1000;
            FirstName = firstName.ToUpper();
            LastName = lastName.ToUpper();
        }

        // overloaded ctor which does null validations
        public Customer(int id, string firstName, string lastName, 
            string email, string mobile, DateTime dateOfBirth) : this(id, firstName, lastName)
        {
            //FirstName = firstName ?? "NO First Name"; // if (FirstName == null) Firstname = "NO First Name"; else FirstName = firstName;
            //LastName = lastName ?? nameof(lastName); // "lastName";
            Email = email ?? throw new Exception(nameof(email));
            Mobile = mobile ?? throw new ArgumentNullException(nameof(mobile));
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Id: {Id}\tFirstName: {FirstName}\tLastName: {LastName}\tEmail: {Email}\tMobile: {Mobile}\tDateOfBirth: {DateOfBirth}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
