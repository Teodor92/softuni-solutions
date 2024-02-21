using ContactsConsoleAPI.Business;
using ContactsConsoleAPI.Business.Contracts;
using ContactsConsoleAPI.Data.Models;
using ContactsConsoleAPI.DataAccess;
using ContactsConsoleAPI.DataAccess.Contrackts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsConsoleAPI.IntegrationTests.NUnit
{
    public class IntegrationTests
    {
        private TestContactDbContext dbContext;
        private IContactManager contactManager;

        [SetUp]
        public void SetUp()
        {
            this.dbContext = new TestContactDbContext();
            this.contactManager = new ContactManager(new ContactRepository(this.dbContext));
        }


        [TearDown]
        public void TearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }

        //positive test
        [Test]
        public async Task AddContactAsync_ShouldAddNewContact()
        {
            // Arrange
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933779"
            };

            // Act
            await contactManager.AddAsync(newContact);

            // Assert
            var dbContact = await dbContext.Contacts.FirstOrDefaultAsync(c => c.Contact_ULID == newContact.Contact_ULID);

            Assert.NotNull(dbContact);
            Assert.AreEqual(newContact.FirstName, dbContact.FirstName);
            Assert.AreEqual(newContact.LastName, dbContact.LastName);
            Assert.AreEqual(newContact.Phone, dbContact.Phone);
            Assert.AreEqual(newContact.Email, dbContact.Email);
            Assert.AreEqual(newContact.Address, dbContact.Address);
            Assert.AreEqual(newContact.Contact_ULID, dbContact.Contact_ULID);
        }

        //Negative test
        [Test]
        public async Task AddContactAsync_TryToAddContactWithInvalidCredentials_ShouldThrowException()
        {
            // Arrnage
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "invalid_Mail", //invalid email
                Gender = "Male",
                Phone = "0889933779"
            };

            // Act and Assert
            var ex = Assert.ThrowsAsync<ValidationException>(async () => await contactManager.AddAsync(newContact));

            var actual = await dbContext.Contacts.FirstOrDefaultAsync(c => c.Contact_ULID == newContact.Contact_ULID);

            Assert.IsNull(actual);
            Assert.That(ex?.Message, Is.EqualTo("Invalid contact!"));

        }

        [Test]
        public async Task DeleteContactAsync_WithValidULID_ShouldRemoveContactFromDb()
        {
            // Arrange
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933779"
            };

            await contactManager.AddAsync(newContact);

            // Get data from db and assert.

            // Act
            await contactManager.DeleteAsync(newContact.Contact_ULID);

            // Assert
            var contactInDb = await dbContext.Contacts.FirstOrDefaultAsync(x => x.Contact_ULID == newContact.Contact_ULID);

            Assert.IsNull(contactInDb);
        }

        [TestCase("")]
        [TestCase("    ")]
        [TestCase(null)]
        public async Task DeleteContactAsync_TryToDeleteWithNullOrWhiteSpaceULID_ShouldThrowException(string invalidUlid)
        {
            // Act and Assert
            var exception = Assert.ThrowsAsync<ArgumentException>(() => contactManager.DeleteAsync(invalidUlid));

            Assert.That(exception.Message, Is.EqualTo("ULID cannot be empty."));
        }

        [Test]
        public async Task GetAllAsync_WhenContactsExist_ShouldReturnAllContacts()
        {
            // Arrange
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933779"
            };

            var secondNewContact = new Contact()
            {
                FirstName = "SecondTestFirstName",
                LastName = "SecondTestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "2ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933778"
            };

            await contactManager.AddAsync(newContact);
            await contactManager.AddAsync(secondNewContact);

            // Act
            var result = await contactManager.GetAllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(2));

            var firstContact = result.First();
            Assert.That(firstContact.Email, Is.EqualTo(newContact.Email));
            // TODO: Add all other props
        }

        [Test]
        public async Task GetAllAsync_WhenNoContactsExist_ShouldThrowKeyNotFoundException()
        {
            // Arrange

            // Act and Assert
            var expection = Assert.ThrowsAsync<KeyNotFoundException>(() => contactManager.GetAllAsync());

            Assert.That(expection.Message, Is.EqualTo("No contact found."));
        }

        [Test]
        public async Task SearchByFirstNameAsync_WithExistingFirstName_ShouldReturnMatchingContacts()
        {
            // Arrange
            var newContacts = new List<Contact>()
            {
                new Contact()
                {
                    FirstName = "TestFirstName",
                    LastName = "TestLastName",
                    Address = "Anything for testing address",
                    Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                    Email = "test@gmail.com",
                    Gender = "Male",
                    Phone = "0889933779"
                },
                new Contact()
                {
                    FirstName = "SecondTestFirstName",
                    LastName = "SecondTestLastName",
                    Address = "Anything for testing address",
                    Contact_ULID = "2ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                    Email = "test@gmail.com",
                    Gender = "Male",
                    Phone = "0889933778"
                }
            };

            foreach (var contact in newContacts) 
            {
                await contactManager.AddAsync(contact);
            }

            // Act
            var result = await contactManager.SearchByFirstNameAsync(newContacts[1].FirstName);

            // Assert
            Assert.That(result.Count(), Is.EqualTo(1));
            var itemInTheDb = result.First();
            Assert.That(itemInTheDb.LastName, Is.EqualTo(newContacts[1].LastName));
            // TODO: Add all asserts
        }

        [Test]
        public async Task SearchByFirstNameAsync_WithNonExistingFirstName_ShouldThrowKeyNotFoundException()
        {
            // Act and Assert
            var exeption = Assert.ThrowsAsync<KeyNotFoundException>(() => contactManager.SearchByFirstNameAsync("NO_SUCH_KEY"));

            Assert.That(exeption.Message, Is.EqualTo("No contact found with the given first name."));
        }

        [Test]
        public async Task SearchByLastNameAsync_WithExistingLastName_ShouldReturnMatchingContacts()
        {
            // Arrange
            var newContacts = new List<Contact>()
            {
                new Contact()
                {
                    FirstName = "TestFirstName",
                    LastName = "TestLastName",
                    Address = "Anything for testing address",
                    Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                    Email = "test@gmail.com",
                    Gender = "Male",
                    Phone = "0889933779"
                },
                new Contact()
                {
                    FirstName = "SecondTestFirstName",
                    LastName = "SecondTestLastName",
                    Address = "Anything for testing address",
                    Contact_ULID = "2ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                    Email = "test@gmail.com",
                    Gender = "Male",
                    Phone = "0889933778"
                }
            };

            foreach (var contact in newContacts)
            {
                await contactManager.AddAsync(contact);
            }

            // Act
            var result = await contactManager.SearchByLastNameAsync(newContacts[0].LastName);

            // Assert
            Assert.That(result.Count(), Is.EqualTo(1));
            var itemInDb = result.First();
            Assert.That(itemInDb.FirstName, Is.EqualTo(newContacts[0].FirstName));
            // TODO: Assert all other props
        }

        [Test]
        public async Task SearchByLastNameAsync_WithNonExistingLastName_ShouldThrowKeyNotFoundException()
        {
            // Act and Assert
            var exception = Assert.ThrowsAsync<KeyNotFoundException>(() => contactManager.SearchByLastNameAsync("NON_EXISTING_NAME"));

            Assert.That(exception.Message, Is.EqualTo("No contact found with the given last name."));
        }

        [Test]
        public async Task GetSpecificAsync_WithValidULID_ShouldReturnContact()
        {
            // Arrange
            var newContacts = new List<Contact>()
            {
                new Contact()
                {
                    FirstName = "TestFirstName",
                    LastName = "TestLastName",
                    Address = "Anything for testing address",
                    Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                    Email = "test@gmail.com",
                    Gender = "Male",
                    Phone = "0889933779"
                },
                new Contact()
                {
                    FirstName = "SecondTestFirstName",
                    LastName = "SecondTestLastName",
                    Address = "Anything for testing address",
                    Contact_ULID = "2ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                    Email = "test@gmail.com",
                    Gender = "Male",
                    Phone = "0889933778"
                }
            };

            foreach (var contact in newContacts)
            {
                await contactManager.AddAsync(contact);
            }

            // Act
            var result = await contactManager.GetSpecificAsync(newContacts[1].Contact_ULID);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.FirstName, Is.EqualTo(newContacts[1].FirstName));
            // TODO: Add all asserts
        }

        [Test]
        public async Task GetSpecificAsync_WithInvalidULID_ShouldThrowKeyNotFoundException()
        {
            // Act And Assert
            const string invalidUlid = "NON_VALID_ID";

            var exception = Assert.ThrowsAsync<KeyNotFoundException>(() => contactManager.GetSpecificAsync(invalidUlid));

            Assert.That(exception.Message, Is.EqualTo($"No contact found with ULID: {invalidUlid}"));
        }

        [Test]
        public async Task UpdateAsync_WithValidContact_ShouldUpdateContact()
        {
            // Arrange
            var newContacts = new List<Contact>()
            {
                new Contact()
                {
                    FirstName = "TestFirstName",
                    LastName = "TestLastName",
                    Address = "Anything for testing address",
                    Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                    Email = "test@gmail.com",
                    Gender = "Male",
                    Phone = "0889933779"
                },
                new Contact()
                {
                    FirstName = "SecondTestFirstName",
                    LastName = "SecondTestLastName",
                    Address = "Anything for testing address",
                    Contact_ULID = "2ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                    Email = "test@gmail.com",
                    Gender = "Male",
                    Phone = "0889933778"
                }
            };

            foreach (var contact in newContacts)
            {
                await contactManager.AddAsync(contact);
            }

            var modifiedContact = newContacts[0];
            modifiedContact.FirstName = "UPDATED!";

            // Act
            await contactManager.UpdateAsync(modifiedContact);

            // Assert
            var itemInDb = await dbContext.Contacts.FirstOrDefaultAsync(x => x.Contact_ULID == modifiedContact.Contact_ULID);

            Assert.NotNull(itemInDb);
            Assert.That(itemInDb.FirstName, Is.EqualTo(modifiedContact.FirstName));
            // TODO: Add asserts for other props.
        }

        [Test]
        public async Task UpdateAsync_WithInvalidContact_ShouldThrowValidationException()
        {
            // Act and Assert
            var exception = Assert.ThrowsAsync<ValidationException>(() => contactManager.UpdateAsync(new Contact()));

            Assert.That(exception.Message, Is.EqualTo("Invalid contact!"));
        }
    }
}
