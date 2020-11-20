using Shopping_bag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_bag.Interfaces
{
    public interface IShoppingBagService
    {
        public Task AddToCart(Guid productId, int amount);
        public int RemoveFromCart(Guid product);
        public ShoppingBag GetShoppingCartItems();
        public decimal GetShoppingCartTotal();
    }
}
