using ContactsConsoleAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContactsConsoleAPI.IntegrationTests.NUnit
{
    public class TestContactDbContext : ContactsDbContext
    {
        public TestContactDbContext()
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
