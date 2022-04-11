using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Product.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository customerRepository)
        {
            _productRepository = customerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllCustomers()
        {
            return await _productRepository.GetAllProducts();
        }
    }
}