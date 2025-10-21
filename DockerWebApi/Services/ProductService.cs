using DockerWebApi.Models;
using DockerWebApi.Repositories.Interfaces;
using DockerWebApi.Services.Interfaces;

namespace DockerWebApi.Services
{
    public class ProductService(IProductRepository _productRepository) : IProductService
    {
        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddProductAsync(product);
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _productRepository.GetProductsAsync();
        }
    }
}
