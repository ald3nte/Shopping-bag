using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shopping_bag.Interfaces;
using Shopping_bag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_bag.Services
{
    public class ShoppingBagService : IShoppingBagService
    {

        private static IList<ShoppingBag> _shoppingBag;
        private Guid ShoppingBagId;
        public ShoppingBagService(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            string bagId = session.GetString("bagId") ?? Guid.NewGuid().ToString();

            session.SetString("bagId", bagId);

            ShoppingBagId = Guid.Parse(bagId);

            var shoppingBag = _shoppingBag.Where(b => b.Id == Guid.Parse(bagId)).FirstOrDefault();

            if (shoppingBag == null)
                _shoppingBag.Add(shoppingBag);

        }

        public void AddToCart(Product product, int amount)
        {

            var shoppingBag = _shoppingBag.FirstOrDefault(b => b.Id == ShoppingBagId);

            var shoppingCartItem = shoppingBag.Items.FirstOrDefault(i => i.productId == product.Id);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingBagItem(Guid.NewGuid(), amount, product.Id);
                shoppingBag.Items.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.amount += amount;
            }

        }

        public ShoppingBag GetShoppingCartItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetShoppingCartTotal()
        {
            throw new NotImplementedException();
        }

        public int RemoveFromCart(Product product)
        {
            return 1;
        }


    }
}
