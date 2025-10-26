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

        public async Task<Product?> GetProductAsync(int id)
        {
            return await _productRepository.GetProductAsync(id);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetProductAsync(id)
                ?? throw new ArgumentException("Product doesn't exist");

            await _productRepository.DeleteProductAsync(product);
        }
    }
}
