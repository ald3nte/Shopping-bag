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
                new Product(Guid.NewGuid(),"T-shirt",99.99,DateTime.Now),
                new Product(Guid.NewGuid(),"Skirt",79.99,DateTime.Now),
                new Product(Guid.NewGuid(),"Jogger",80.99,DateTime.Now),
                new Product(Guid.NewGuid(),"Bag",20.99,DateTime.Now),
                new Product(Guid.NewGuid(),"Cap",15.00,DateTime.Now)
            };
        public async Task<IEnumerable<Product>>GetProducts()
            {
                var products = _products.ToList();

            return await Task.FromResult(products);
            }
        public async Task<Product>GetProductById(Guid productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            return await Task.FromResult(product);
        }
    }
}
