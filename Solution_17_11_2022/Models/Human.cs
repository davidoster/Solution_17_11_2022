using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_17_11_2022.Models
{
    internal class Human
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\tFirstName: {FirstName}\tLastName: {LastName}\tEmail: {Email}\tMobile: {Mobile}\tDate Of Birth: {DateOfBirth}";
        }
    }
}
