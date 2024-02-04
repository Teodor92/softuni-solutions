using Microsoft.EntityFrameworkCore;
using TownsApplication.Data.Models;

namespace TownsApplication.Data
{
    public class TownDbContext : DbContext
    {
        public DbSet<Town> Towns { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        }
    }
}
