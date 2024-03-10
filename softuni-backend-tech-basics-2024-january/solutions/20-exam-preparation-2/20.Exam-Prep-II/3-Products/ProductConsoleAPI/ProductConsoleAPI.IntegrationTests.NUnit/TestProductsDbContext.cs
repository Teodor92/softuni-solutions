using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductConsoleAPI.DataAccess;

namespace ProductConsoleAPI.IntegrationTests.NUnit
{
    public class TestProductsDbContext : ProductsDbContext
    {
        public TestProductsDbContext()
            : base(new ConfigurationBuilder().AddInMemoryCollection().Build())
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("TestDatabase");
            }
        }
    }
}
