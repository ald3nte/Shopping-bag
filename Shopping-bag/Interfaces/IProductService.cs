using Shopping_bag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_bag.Interfaces
{
    public interface IProductService
    {

        public  Task<IEnumerable<Product>> GetProducts();
    }
}
