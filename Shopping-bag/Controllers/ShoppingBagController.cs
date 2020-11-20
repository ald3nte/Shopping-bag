using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping_bag.Interfaces;

namespace Shopping_bag.Controllers
{
    public class ShoppingBagController : Controller
    {
        private readonly IShoppingBagService _shoppingBag;
        private readonly IProductService _productService;

        public ShoppingBagController(IShoppingBagService shoppingBag, IProductService productService)
        {
            _shoppingBag = shoppingBag;
            _productService = productService;
        }

        public IActionResult AddToBag(Guid productId)
        {
            _shoppingBag.AddToCart(productId, 1);
            return Redirect(Request.GetTypedHeaders().Referer.ToString());
        }

        public IActionResult ShoppingBagItemsList()
        {
            var shoppingCartItems = _shoppingBag.GetShoppingCartItems();


            return View(shoppingCartItems);
        }
    }
}
