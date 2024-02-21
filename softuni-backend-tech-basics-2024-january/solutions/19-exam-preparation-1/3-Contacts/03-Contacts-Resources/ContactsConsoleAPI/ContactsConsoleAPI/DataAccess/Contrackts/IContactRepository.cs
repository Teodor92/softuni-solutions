using ContactsConsoleAPI.Data.Models;

namespace ContactsConsoleAPI.DataAccess.Contrackts
{
    public  interface IContactRepository
    {
        Task<Contact> GetContactByULIDAsync(string ulid);
        Task<IEnumerable<Contact>> GetAllContactsAsync();
        Task<IEnumerable<Contact>> SearchContactsByFirstName(string firstName);
        Task<IEnumerable<Contact>> SearchContactsByLastName(string lastName);
        Task AddContactAsync(Contact contact);
        Task UpdateContactAsync(Contact contact);
        Task DeleteContactAsync(string ulid);
    }
}

