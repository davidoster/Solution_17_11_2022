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

        public Human()
        {
            Id = -1;
            FirstName = "No Name";
            LastName = "No Name";
            Email = "no email";
            Mobile = "---";
            DateOfBirth= new DateTime(1,1,1);
        }
        public Human(int id, string firstName, string lastName, string email, string mobile, DateTime dateOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Mobile = mobile;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Id: {Id}\tFirstName: {FirstName}\tLastName: {LastName}\tEmail: {Email}\tMobile: {Mobile}\tDate Of Birth: {DateOfBirth}";
        }
    }
}
