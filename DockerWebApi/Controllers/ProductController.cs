using DockerWebApi.Models;
using DockerWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DockerWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(IProductService _productService) : ControllerBase
    {
        [HttpGet]
        public async Task<List<Product>> GetAsync()
        {
            return await _productService.GetProductsAsync();
        }

        [HttpPost]
        public async Task<bool> PostAsync(Product product)
        {
            await _productService.AddProductAsync(product);
            return true;
        }
    }
}
