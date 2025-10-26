using DockerWebApi.Models;

namespace DockerWebApi.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product?> GetProductAsync(int id);
        Task AddProductAsync(Product product);
    }
}
