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
        public Guid productId { get; set; }
        public ShoppingBag shoppingBag { get; set; }
        public ShoppingBagItem(Guid id, int amount, Guid productId)
        {
            Id = id;
            this.amount = amount;
            this.productId = productId;
        }
    }
}
