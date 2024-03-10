using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductConsoleAPI.Data.Models;

namespace ProductConsoleAPI.DataAccess
{
    public  class ProductsDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }


        public ProductsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public ProductsDbContext(IConfigurationRoot configurationRoot)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
