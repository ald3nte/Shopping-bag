using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_bag.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime DateTime { get; set; }

        

        public Product(Guid id, string name, double price, DateTime dateTime)
        {
            Id = id;
            Name = name;
            Price = price;
            DateTime = dateTime;
        }
    }
}
