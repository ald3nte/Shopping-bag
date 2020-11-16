using Shopping_bag.Interfaces;
using Shopping_bag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Shopping_bag.Services
{
    public class ProductService : IProductService
    {
        private static readonly ISet<Product> _products = new HashSet<Product>
            {
                new Product(1,"T-shirt",99.99,DateTime.Now),
                new Product(2,"Skirt",79.99,DateTime.Now),
                new Product(3,"Jogger",80.99,DateTime.Now),
                new Product(4,"Bag",20.99,DateTime.Now),
                new Product(5,"Cap",15.00,DateTime.Now)
            };
        public async Task<IEnumerable<Product>>GetProducts()
            {
                var products = _products.ToList();

            return await Task.FromResult(products);
            }
    }
}
