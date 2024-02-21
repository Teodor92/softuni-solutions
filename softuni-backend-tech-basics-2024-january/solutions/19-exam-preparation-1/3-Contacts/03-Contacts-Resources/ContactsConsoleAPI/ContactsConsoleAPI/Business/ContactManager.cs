using ContactsConsoleAPI.Business.Contracts;
using ContactsConsoleAPI.Data.Models;
using ContactsConsoleAPI.DataAccess.Contrackts;
using System.ComponentModel.DataAnnotations;

namespace ContactsConsoleAPI.Business
{
    public class ContactManager : IContactManager
    {
        private readonly IContactRepository repository;

        public ContactManager(IContactRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddAsync(Contact contact)
        {
            if(!IsValid(contact))
            {
                throw new ValidationException("Invalid contact!");
            }
            else
            {
                await repository.AddContactAsync(contact);
            }
        }

        public Task DeleteAsync(string ulid)
        {
            if (string.IsNullOrWhiteSpace(ulid))
            {
                throw new ArgumentException("ULID cannot be empty.");
            }

            return repository.DeleteContactAsync(ulid);
        }

        public async Task<IEnumerable<Contact>> GetAllAsync()
        {
            var contacts = await repository.GetAllContactsAsync();

            if (!contacts.Any())
            {
                throw new KeyNotFoundException("No contact found.");
            }

            return contacts;
        }

        public async Task<Contact> GetSpecificAsync(string ulid)
        {
            if (string.IsNullOrWhiteSpace(ulid))
            {
                throw new ArgumentException("ULID cannot be empty.");
            }

            var contact = await repository.GetContactByULIDAsync(ulid);

            if (contact == null)
            {
                throw new KeyNotFoundException($"No contact found with ULID: {ulid}");
            }

            return contact;
        }

        public async Task<IEnumerable<Contact>> SearchByFirstNameAsync(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be empty.");
            }

            var contacts = await repository.SearchContactsByFirstName(firstName);

            if (contacts == null || !contacts.Any())
            {
                throw new KeyNotFoundException("No contact found with the given first name.");
            }

            return contacts;
        }

        public async Task<IEnumerable<Contact>> SearchByLastNameAsync(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name cannot be empty.");
            }

            var contacts = await repository.SearchContactsByLastName(lastName);

            if (contacts == null || !contacts.Any())
            {
                throw new KeyNotFoundException("No contact found with the given last name.");
            }

            return contacts;
        }

        public async Task UpdateAsync(Contact contact)
        {
            if (!IsValid(contact))
            {
                throw new ValidationException("Invalid contact!");
            }

            await repository.UpdateContactAsync(contact);
        }

        private bool IsValid(Contact contact)
        {
            if (contact == null)
            {
                return false;
            }

            var validateResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            if (!Validator.TryValidateObject(contact, validationContext, validateResults, true))
            {
                foreach (var validationResult in validateResults)
                {
                    Console.WriteLine($"Validation Error: {validationResult.ErrorMessage}");
                }
                return false;
            }

            return true;
        }
    }
}
