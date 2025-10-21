using DockerWebApi.Models;

namespace DockerWebApi.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task AddProductAsync(Product product);
    }
}
