using DockerWebApi.Database;
using DockerWebApi.Models;
using DockerWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DockerWebApi.Repositories
{
    public class ProductRepository(AppDbContext _context) : IProductRepository
    {
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProductAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
    }
}
