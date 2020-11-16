using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping_bag.Interfaces;
using Shopping_bag.Models;
using Shopping_bag.Services;
using Shopping_bag.ViewModel;

namespace Shopping_bag.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productsService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productsService = productService;
        }

        public async Task<IActionResult> Index()
        {


            ProductsListViewModel prodcutPageViewModel = new ProductsListViewModel()
            {
                Products = await _productsService.GetProducts(),
                title = "Produkty"
            };

            return View(prodcutPageViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
