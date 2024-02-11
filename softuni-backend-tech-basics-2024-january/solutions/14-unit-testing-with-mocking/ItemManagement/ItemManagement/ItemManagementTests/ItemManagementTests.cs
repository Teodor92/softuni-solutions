using NUnit.Framework;
using Moq;
using ItemManagementApp.Services;
using ItemManagementLib.Repositories;
using ItemManagementLib.Models;
using System.Collections.Generic;
using System.Linq;

namespace ItemManagement.Tests
{
    [TestFixture]
    public class ItemServiceTests
    {
        private ItemService _itemService;
        private Mock<IItemRepository> _mockItemRepository;
        
        [SetUp]
        public void Setup()
        {
            // Arrange: Create a mock instance of IItemRepository
            _mockItemRepository = new Mock<IItemRepository>();
            // Instantiate ItemService with the mocked repository
            _itemService = new ItemService(_mockItemRepository.Object);
        }

        [Test]
        public void AddItem_ShouldItemItem_IfNameIsValid()
        {
            // Arrange
            var item = new Item { Name = "Test Item" };
            _mockItemRepository.Setup(x => x.AddItem(It.IsAny<Item>()));

            // Act
            _itemService.AddItem(item.Name);

            // Assert
            _mockItemRepository.Verify(x => x.AddItem(It.IsAny<Item>()), Times.Once());
        }

        [Test]
        public void AddItem_ShouldThrowError_IfNameIsInvalid()
        {
            // Arrange
            string invalidName = "";
            _mockItemRepository
                   .Setup(x => x.AddItem(It.IsAny<Item>()))
                   .Throws<ArgumentException>();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => _itemService.AddItem(invalidName));
            _mockItemRepository.Verify(x => x.AddItem(It.IsAny<Item>()), Times.Once());
        }

        [Test]
        public void GetAllItems_ShoudlReturnAllItems()
        {
            // Arrange
            var items = new List<Item>() { new Item { Id = 1, Name = "SampleItem", } };
            _mockItemRepository.Setup(x => x.GetAllItems()).Returns(items);

            // Act
            var result = _itemService.GetAllItems();

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(1));
            _mockItemRepository.Verify(x => x.GetAllItems(), Times.Once());
        }

        [Test]
        public void GetItemById_ShouldReturnItemById_IfItemExists()
        {
            // Arrange
            var item = new Item { Id = 1, Name = "Single Item" };
            _mockItemRepository.Setup(x => x.GetItemById(item.Id)).Returns(item);

            // Act
            var result = _itemService.GetItemById(item.Id);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Name, Is.EqualTo(item.Name));
            _mockItemRepository.Verify(x => x.GetItemById(item.Id), Times.Once());
        }

        [Test]
        public void GetItemById_ShouldReturnNull_IfItemDoesNotExists()
        {
            // Arrange
            _mockItemRepository.Setup(x => x.GetItemById(It.IsAny<int>())).Returns<Item>(null);

            // Act
            var result = _itemService.GetItemById(123);

            // Assert
            Assert.Null(result);
            _mockItemRepository.Verify(x => x.GetItemById(It.IsAny<int>()), Times.Once());
        }

        [Test]
        public void UpdateItem_ShouldNotUpdateItem_IfItemDoesNotExist()
        {
            // Arrange
            var nonExisitingId = 1;
            _mockItemRepository.Setup(x => x.GetItemById(nonExisitingId)).Returns<Item>(null);
            _mockItemRepository.Setup(x => x.UpdateItem(It.IsAny<Item>()));

            // Act
            _itemService.UpdateItem(nonExisitingId, "DoesNotMatter");

            // Assert
            _mockItemRepository.Verify(x => x.GetItemById(nonExisitingId), Times.Once());
            _mockItemRepository.Verify(x => x.UpdateItem(It.IsAny<Item>()), Times.Never);
        }

        [Test]
        public void UpdateItem_ShouldThrowExeption_IfItemNameIsInvalid()
        {
            // Arrange
            var item = new Item { Name = "Sample Item", Id = 1 };
            _mockItemRepository.Setup(x => x.GetItemById(item.Id)).Returns(item);
            _mockItemRepository
                .Setup(x => x.UpdateItem(It.IsAny<Item>()))
                .Throws<ArgumentException>();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => _itemService.UpdateItem(item.Id, ""));

            _mockItemRepository.Verify(x => x.GetItemById(item.Id), Times.Once());
            _mockItemRepository.Verify(x => x.UpdateItem(It.IsAny<Item>()), Times.Once());
        }

        [Test]
        public void UpdateItem_ShouldUpdateItem_IfItemNameIsValid()
        {
            // Arrange
            var item = new Item { Name = "Sample Item", Id = 1 };
            _mockItemRepository.Setup(x => x.GetItemById(item.Id)).Returns(item);
            _mockItemRepository
                .Setup(x => x.UpdateItem(It.IsAny<Item>()));

            // Act 
            _itemService.UpdateItem(item.Id, "Sample Item Update");

            // Assert
            _mockItemRepository.Verify(x => x.GetItemById(item.Id), Times.Once());
            _mockItemRepository.Verify(x => x.UpdateItem(It.IsAny<Item>()), Times.Once());
        }

        [Test]
        public void DeleteItem_ShouldDeleteItem()
        {
            // Arrange
            var itemId = 12;
            _mockItemRepository.Setup(x => x.DeleteItem(itemId));

            // Act
            _itemService.DeleteItem(itemId);

            // Assert
            _mockItemRepository.Verify(x => x.DeleteItem(itemId), Times.Once());
        }

        [TestCase("", false)]
        [TestCase(null, false)]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", false)]
        [TestCase("A", true)]
        [TestCase("SampleName", true)]
        [TestCase("Sample", true)]
        public void ValidateItemName_ShouldReutrnCorrectAnswer_IfItemNameIsValid(string name, bool isValid)
        {
            // Act
            var result = _itemService.ValidateItemName(name);

            // Assert
            Assert.That(result, Is.EqualTo(isValid));
        }
    }
}