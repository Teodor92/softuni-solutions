using Eventmi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Eventmi.Infrastructure.Data.Contexts
{
    public class EventmiContext : DbContext
    {
        public EventmiContext()
        {
        }

        public EventmiContext(DbContextOptions<EventmiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}