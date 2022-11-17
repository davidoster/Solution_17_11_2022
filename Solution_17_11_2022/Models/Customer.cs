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

        public Customer()
        {           
            Id = -1; // 2nd
        }

        public Customer(int id)
        {
            Id = id; // 3rd
        }

        public override string ToString()
        {
            return $"Id: {Id}, FirstName: {FirstName}, _firstname: {_firstname}";
        }

        //private void ChangeId(int id)
        //{
        //    if(id <= 0)
        //    {
        //        Id = 1;
        //    } else
        //    {
        //        Id = id + 5000;
        //    }
        //}
    }
}
