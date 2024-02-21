using ContactsConsoleAPI.Data.Models;

namespace ContactsConsoleAPI.Business.Contracts
{
    public interface IContactManager
    {
        Task AddAsync(Contact contact);
        Task<IEnumerable<Contact>> GetAllAsync();
        Task<IEnumerable<Contact>> SearchByFirstNameAsync(string firstName);
        Task<IEnumerable<Contact>> SearchByLastNameAsync(string lastName);
        Task<Contact> GetSpecificAsync(string ulid);
        Task UpdateAsync(Contact contact);
        Task DeleteAsync(string ulid);
    }
}
