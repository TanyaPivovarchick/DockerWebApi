using DockerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerWebApi.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
