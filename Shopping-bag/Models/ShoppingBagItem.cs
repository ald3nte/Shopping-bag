using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_bag.Models
{
    public class ShoppingBagItem
    {
        public Guid Id { get; set; }
        public int amount { get; set; }
        public Product product { get; set; }
        public ShoppingBag shoppingBag { get; set; }
        public ShoppingBagItem(Guid id, int amount, Product product)
        {
            Id = id;
            this.amount = amount;
            this.product = product;
        }
    }
}
