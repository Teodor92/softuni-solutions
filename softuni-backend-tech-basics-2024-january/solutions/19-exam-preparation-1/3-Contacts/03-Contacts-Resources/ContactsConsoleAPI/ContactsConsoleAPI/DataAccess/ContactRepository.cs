using ContactsConsoleAPI.Data.Models;
using ContactsConsoleAPI.DataAccess.Contrackts;
using Microsoft.EntityFrameworkCore;

namespace ContactsConsoleAPI.DataAccess
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactsDbContext context;

        public ContactRepository(ContactsDbContext context)
        {
            this.context = context;
        }
        public async Task AddContactAsync(Contact contact)
        {
            await context.Contacts.AddAsync(contact);
            await context.SaveChangesAsync();
        }

        public async Task DeleteContactAsync(string ulid)
        {
            var contact = await context.Contacts.FirstOrDefaultAsync(c => c.Contact_ULID == ulid);
            if (contact != null)
            {
                context.Contacts.Remove(contact);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Contact>> GetAllContactsAsync()
        {
            var contacts = await context.Contacts.ToListAsync();
            return contacts;
        }

        public async Task<Contact> GetContactByULIDAsync(string ulid)
        {
            var contact = await context.Contacts.FirstOrDefaultAsync(c => c.Contact_ULID == ulid);
            return contact;
        }

        public async Task<IEnumerable<Contact>> SearchContactsByFirstName(string firstName)
        {
            var contact = await context.Contacts.Where(c => c.FirstName == firstName).ToListAsync();
            return contact;
        }

        public async Task<IEnumerable<Contact>> SearchContactsByLastName(string lastName)
        {
            var contact = await context.Contacts.Where(c => c.LastName == lastName).ToListAsync();
            return contact;
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            context.Contacts.Update(contact);
            await context.SaveChangesAsync();
        }
    }
}
