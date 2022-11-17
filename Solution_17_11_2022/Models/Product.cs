using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_16_11_2022.Models
{
    internal class Product // name of the class is on singular
    {
        // private == nobobdy can access from outside of this class

        private string _name; // private fields
        
        // public == everybody has access from everywhere
        public int Id { get; set; } // public properties
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string SerialNo { get; set; }
        public bool IsActive { get; set; }

        // constructor - method SPECIAL
        // default
        public Product()
        {
            // during construction of an object all the fields and/or properties get an initial
            // default value, they are assigned a value based on their type
            // int, decimal, double, float = 0
            // string = ""
            // bool = False
            //Console.WriteLine("I am the Product!!!");
            //Console.WriteLine($"_name: {_name}, Id: {Id}, Title: {Title}, Desc: {Description}, Price: {Price}, SerialNo: {SerialNo}, IsActive: {IsActive}");
        }

        // constructor, overloaded
        public Product(int Id, string Title)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = "No Description";
        }

        // constructor, overloaded
        public Product(int Id, string Title, 
            string Description, double Price, string SerialNo)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Price = Price;
            this.SerialNo = SerialNo;
        }

        public override string ToString()
        {
            return $"_name: {_name}, Id: {Id}, Title: {Title}, Desc: {Description}, Price: {Price.ToString("0.###")}, SerialNo: {SerialNo}, IsActive: {IsActive}";
        }


        /*
         * JS
         * function Hello(text) { console.log(text); }
         */
    }
}
