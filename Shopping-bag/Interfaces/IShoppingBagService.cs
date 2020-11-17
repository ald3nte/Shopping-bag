using Shopping_bag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_bag.Interfaces
{
    public interface IShoppingBagService
    {
        public void AddToCart(Product product, int amount);
        public int RemoveFromCart(Product product);
        public ShoppingBag GetShoppingCartItems();
        public decimal GetShoppingCartTotal();
    }
}
