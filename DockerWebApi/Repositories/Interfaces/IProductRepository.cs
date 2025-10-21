using DockerWebApi.Models;

namespace DockerWebApi.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task AddProductAsync(Product product);
    }
}
