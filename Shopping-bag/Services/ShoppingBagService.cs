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

        private static ISet<ShoppingBag> _shoppingBag = new HashSet<ShoppingBag>();
        private  readonly IProductService _productService;
        private Guid ShoppingBagId;
        public ShoppingBagService(IServiceProvider services,IProductService productService)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            _productService = productService;

            string bagId = session.GetString("bagId") ?? Guid.NewGuid().ToString();

            session.SetString("bagId", bagId);

            ShoppingBagId = Guid.Parse(bagId);

            var shoppingBag = _shoppingBag.Where(b => b.Id == Guid.Parse(bagId)).FirstOrDefault();

            if (shoppingBag == null)
                shoppingBag = new ShoppingBag(ShoppingBagId);
                _shoppingBag.Add(shoppingBag);

        }

        public async Task AddToCart(Guid productId, int amount)
        {

            var shoppingBag = _shoppingBag.FirstOrDefault(b => b.Id == ShoppingBagId);

            var shoppingCartItem = shoppingBag.Items.FirstOrDefault(i => i.product.Id == productId);

            if (shoppingCartItem == null)
            {

                var product = await _productService.GetProductById(productId);

                shoppingCartItem = new ShoppingBagItem(Guid.NewGuid(), amount,product);
                _shoppingBag.FirstOrDefault(b => b.Id == ShoppingBagId).Items.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.amount += amount;
            }

        }

        public ShoppingBag GetShoppingCartItems()
        {
            var shoppingBag = _shoppingBag.FirstOrDefault(b => b.Id == ShoppingBagId);

            return shoppingBag;
        }

        public decimal GetShoppingCartTotal()
        {
            var shoppingBag = _shoppingBag.FirstOrDefault(b => b.Id == ShoppingBagId);

            var shoppingBagAmount = shoppingBag.Items.Select(c => c.amount).Sum();

            return shoppingBagAmount;
        }

        public int RemoveFromCart(Guid productId)
        {
            var shoppingBag = _shoppingBag.FirstOrDefault(b => b.Id == ShoppingBagId);
            var shopingBagItem=shoppingBag.Items.FirstOrDefault(p => p.product.Id == productId);

            if (shopingBagItem == null)
            {
                shoppingBag.Items.Remove(shopingBagItem);
                return 0;
            }
            return 1;
            // save changes
        }


    }
}
