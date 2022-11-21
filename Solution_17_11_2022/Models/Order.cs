using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_16_11_2022.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public decimal Price { get; private set; }
        public string Description { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } // Homework: at set recalculate the Price Order.Products = new List<Product> {}
        // How to recalculate the Final Price when a user does Products.Add.... ?????? Homework?????

        // int Id, decimal Price, string Description, Date PurchaseDate, Customer Customer, List<Products> Products
        // Employee
        // decimal FinalPrice = Price + 3% + 0.2%
        // tax 3% + 0.2%

        public Order()
        {

        }
        public Order(int id, string description, DateTime purchaseDate, Customer customer, List<Product> products)
        {
            Id = id;
            Description = description;
            PurchaseDate = purchaseDate;
            Customer = customer;
            Products = products;
            Price = (decimal)Products.Sum(product => product.Price); // type casting / LING query + 3% + 0.2%
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Order with Id: {Id}\tPrice: {Price}\tDescription: {Description}\tPurchase Date: {PurchaseDate}");
            stringBuilder.AppendLine($"For Customer with Id: {Customer.Id}\tLast Name: {Customer.LastName}\tFirst Name: {Customer.FirstName}");
            stringBuilder.AppendLine($"List Of Products ({Products.Count})");
            for(int i = 0; i < Products.Count; i++) 
            {
                stringBuilder.AppendLine($"Product {i + 1}: {Products[i]}");
            }

            return stringBuilder.ToString();
        }
    }
}
