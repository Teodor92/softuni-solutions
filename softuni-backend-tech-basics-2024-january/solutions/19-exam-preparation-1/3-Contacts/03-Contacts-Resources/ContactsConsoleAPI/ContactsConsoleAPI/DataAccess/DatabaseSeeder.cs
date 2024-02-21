using ContactsConsoleAPI.Business;
using ContactsConsoleAPI.Data.Models;
using System.Text.Json;

namespace ContactsConsoleAPI.DataAccess
{
    public class DatabaseSeeder
    {
        public static async Task SeedDatabaseAsync(ContactsDbContext context, ContactManager contactManager)
        {
            if (context.Contacts.Count() == 0)
            {
                string jsonFilePath = Path.Combine("Data", "Seed", "contacts.json");
                string jsonData = File.ReadAllText(jsonFilePath);

                var contacts = JsonSerializer.Deserialize<List<Contact>>(jsonData);

                if (contacts != null)
                {
                    foreach (var contact in contacts)
                    {
                        if (!context.Contacts.Any(c => c.Contact_ULID == contact.Contact_ULID))
                        {
                            var newContact = new Contact()
                            {
                                Address = contact.Address,
                                Email = contact.Email,
                                FirstName = contact.FirstName,
                                LastName = contact.LastName,
                                Contact_ULID = contact.Contact_ULID,
                                Gender = contact.Gender,
                                Phone = contact.Phone,
                            };
                            await contactManager.AddAsync(newContact);
                        }
                    }

                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
