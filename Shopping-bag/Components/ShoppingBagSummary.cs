using Microsoft.AspNetCore.Mvc;
using Shopping_bag.Interfaces;
using Shopping_bag.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_bag.Components
{
    public class ShoppingBagSummary:ViewComponent
    {

        private readonly IShoppingBagService _shoppingBag;

        public ShoppingBagSummary(IShoppingBagService shoppingBagService)
        {
            _shoppingBag = shoppingBagService;
        }

        public IViewComponentResult Invoke()
        {
            var totalItems = _shoppingBag.GetShoppingCartTotal();

            return View(totalItems);
        }
    }
}
