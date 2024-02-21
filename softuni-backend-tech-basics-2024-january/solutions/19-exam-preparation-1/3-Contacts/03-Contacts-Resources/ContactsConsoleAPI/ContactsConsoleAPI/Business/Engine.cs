using ContactsConsoleAPI.Business.Contracts;
using ContactsConsoleAPI.Data.Models;

namespace ContactsConsoleAPI.Business
{
    public class Engine : IEngine
    {
        public async Task Run(IContactManager contactManager)
        {
            bool exitRequested = false;
            while (!exitRequested)
            {
                Console.WriteLine($"{Environment.NewLine}Choose an option:");
                Console.WriteLine("1: Add Contact");
                Console.WriteLine("2: Delete Contact");
                Console.WriteLine("3: List All Contacts");
                Console.WriteLine("4: Update Contact");
                Console.WriteLine("5: Find Contact by First name");
                Console.WriteLine("6: Find Contact by Last name");
                Console.WriteLine("X: Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await AddContact(contactManager);
                        break;
                    case "2":
                        await DeleteBook(contactManager);
                        break;
                    case "3":
                        await ListAllBooks(contactManager);
                        break;
                    case "4":
                        await UpdateContact(contactManager);
                        break;
                    case "5":
                        await FindBookByFirstName(contactManager);
                        break;
                        case "6":
                        await FindBookByLastName(contactManager);
                        break;
                    case "X":
                    case "x":
                        exitRequested = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                static async Task AddContact(IContactManager contactManager)
                {
                    Console.WriteLine("Adding a new contact:");

                    Console.Write("Enter FirstName: ");
                    var firstName = Console.ReadLine();

                    Console.Write("Enter LastName: ");
                    var lastName = Console.ReadLine();

                    Console.Write("Enter Address: ");
                    var address = Console.ReadLine();

                    Console.Write("Enter Phone number: ");
                    var phone = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    var email = Console.ReadLine();

                    Console.Write("Choice Gender: ");
                    var gender = Console.ReadLine();

                    Console.Write("Enter ULID: ");
                    var ulid = Console.ReadLine();

                    var newContact = new Contact
                    {
                        Address = address,
                        Contact_ULID = ulid,
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        Gender = gender,
                        Phone = phone
                    };

                    await contactManager.AddAsync(newContact);
                    Console.WriteLine("Contact added successfully.");
                }

                static async Task DeleteBook(IContactManager contactManager)
                {
                    Console.Write("Enter ULID of the contact to delete it: ");
                    string ulid = Console.ReadLine();
                    await contactManager.DeleteAsync(ulid);
                    Console.WriteLine("Contact deleted successfully.");
                }

                static async Task ListAllBooks(IContactManager contactManager)
                {
                    var contacts = await contactManager.GetAllAsync();
                    if (contacts.Any())
                    {
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine($"ULID: {contact.Contact_ULID}, Name: {contact.FirstName} {contact.LastName}, Phone: {contact.Phone}, Email: {contact.Email}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No contacts available.");
                    }
                }

                static async Task UpdateContact(IContactManager contactManager)
                {
                    Console.Write("Enter ULID of the contact to update: ");
                    string ulid = Console.ReadLine();
                    var contactToUpdate = await contactManager.GetSpecificAsync(ulid);
                    if (contactToUpdate == null)
                    {
                        Console.WriteLine("Contact not found.");
                        return;
                    }
                    // HERE AM I
                    Console.Write("Enter new First name (leave blank to keep current): ");
                    var firstName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(firstName))
                    {
                        contactToUpdate.FirstName = firstName;
                    }

                    Console.Write("Enter new Last name (leave blank to keep current): ");
                    var lastName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(lastName))
                    {
                        contactToUpdate.LastName = lastName;
                    }

                    Console.Write("Enter new Email (leave blank to keep current): ");
                    var email = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        contactToUpdate.Email = email;
                    }

                    Console.Write("Enter new Phone number (leave blank to keep current): ");
                    var phone = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(phone))
                    {
                        contactToUpdate.Phone = phone;
                    }

                    Console.Write("Enter new Address (leave blank to keep current): ");
                    var address = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(address))
                    {
                        contactToUpdate.Address = address;
                    }

                    Console.Write("Change the gender of the contact (leave blank to keep current): ");
                    var gender = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(gender))
                    {
                        contactToUpdate.Gender = gender;
                    }

                    await contactManager.UpdateAsync(contactToUpdate);
                    Console.WriteLine("Contact updated successfully.");
                }

                static async Task FindBookByFirstName(IContactManager contactManager)
                {
                    Console.Write("Enter the first name of contact: ");
                    string firstName = Console.ReadLine();
                    var contacts = await contactManager.SearchByFirstNameAsync(firstName);

                    if (contacts.Any())
                    {
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"First name: {contact.FirstName}, Last name: {contact.LastName}, Gender: {contact.Gender}");
                            Console.WriteLine($"--Phone: {contact.Phone}, Email: {contact.Email}");
                            Console.WriteLine($"---Address: {contact.Address}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No contact found with the given first name fragment.");
                    }
                }

                static async Task FindBookByLastName(IContactManager contactManager)
                {
                    Console.Write("Enter the last name of contact: ");
                    string lastName = Console.ReadLine();
                    var contacts = await contactManager.SearchByLastNameAsync(lastName);

                    if (contacts.Any())
                    {
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"First name: {contact.FirstName}, Last name: {contact.LastName}, Gender: {contact.Gender}");
                            Console.WriteLine($"--Phone: {contact.Phone}, Email: {contact.Email}");
                            Console.WriteLine($"---Address: {contact.Address}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No contact found with the given last name fragment.");
                    }
                }
            }
        }
    }
}
