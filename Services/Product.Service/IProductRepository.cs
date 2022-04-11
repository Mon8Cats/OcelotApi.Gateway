using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Service
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllProducts();
    }
}