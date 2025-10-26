using DockerWebApi.Models;
using DockerWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DockerWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(IProductService _productService) : ControllerBase
    {
        [HttpGet("GetProducts")]
        public async Task<List<Product>> GetAllAsync()
        {
            return await _productService.GetProductsAsync();
        }

        [HttpGet("GetProduct")]
        public async Task<Product?> GetAsync(int id)
        {
            return await _productService.GetProductAsync(id);
        }

        [HttpPost("AddProduct")]
        public async Task<bool> PostAsync(Product product)
        {
            await _productService.AddProductAsync(product);
            return true;
        }

        [HttpDelete("DeleteProduct")]
        public async Task<bool> DeleteAsync(int id)
        {
            await _productService.DeleteProductAsync(id);
            return true;
        }
    }
}
