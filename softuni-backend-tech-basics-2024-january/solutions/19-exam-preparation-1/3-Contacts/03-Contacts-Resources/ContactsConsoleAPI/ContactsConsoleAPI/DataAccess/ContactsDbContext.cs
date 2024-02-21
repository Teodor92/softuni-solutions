using ContactsConsoleAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContactsConsoleAPI.DataAccess
{
    public class ContactsDbContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }


        public ContactsDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public ContactsDbContext(IConfigurationRoot configurationRoot)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
