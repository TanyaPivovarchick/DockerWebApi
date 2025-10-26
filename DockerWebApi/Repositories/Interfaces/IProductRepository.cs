using DockerWebApi.Models;

namespace DockerWebApi.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product?> GetProductAsync(int id);
        Task AddProductAsync(Product product);
        Task DeleteProductAsync(Product product);
    }
}
