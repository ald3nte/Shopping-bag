using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_bag.Models
{
    public class ShoppingBag
    {
        public Guid Id { get; set; }
        public List<ShoppingBagItem> Items { get; set; }
        public DateTime DateTime { get; set; }

        public ShoppingBag(Guid id)
        {
            Id = id;
            DateTime = DateTime.Now;
            
        }
    }
}
