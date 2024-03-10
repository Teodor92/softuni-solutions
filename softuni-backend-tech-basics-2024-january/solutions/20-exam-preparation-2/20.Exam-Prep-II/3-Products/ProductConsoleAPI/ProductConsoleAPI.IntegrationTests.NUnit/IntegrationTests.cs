using Microsoft.EntityFrameworkCore;
using ProductConsoleAPI.Business;
using ProductConsoleAPI.Business.Contracts;
using ProductConsoleAPI.Data.Models;
using ProductConsoleAPI.DataAccess;
using System.ComponentModel.DataAnnotations;

namespace ProductConsoleAPI.IntegrationTests.NUnit
{
    public  class IntegrationTests
    {
        private TestProductsDbContext dbContext;
        private IProductsManager productsManager;

        [SetUp]
        public void SetUp()
        {
            this.dbContext = new TestProductsDbContext();
            this.productsManager = new ProductsManager(new ProductsRepository(this.dbContext));
        }


        [TearDown]
        public void TearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }


        //positive test
        [Test]
        public async Task AddProductAsync_ShouldAddNewProduct()
        {
            var newProduct = new Product()
            {
                OriginCountry = "Bulgaria",
                ProductName = "TestProduct",
                ProductCode = "AB12C",
                Price = 1.25m,
                Quantity = 100,
                Description = "Anything for description"
            };

            await productsManager.AddAsync(newProduct);

            var dbProduct = await this.dbContext.Products.FirstOrDefaultAsync(p => p.ProductCode == newProduct.ProductCode);

            Assert.NotNull(dbProduct);
            Assert.That(dbProduct.ProductName, Is.EqualTo(newProduct.ProductName));
            Assert.That(dbProduct.Description, Is.EqualTo(newProduct.Description));
            Assert.That(dbProduct.Price, Is.EqualTo(newProduct.Price));
            Assert.That(dbProduct.Quantity, Is.EqualTo(newProduct.Quantity));
            Assert.That(dbProduct.OriginCountry, Is.EqualTo(newProduct.OriginCountry));
            Assert.That(dbProduct.ProductCode, Is.EqualTo(newProduct.ProductCode));
        }

        //Negative test
        [Test]
        public async Task AddProductAsync_TryToAddProductWithInvalidCredentials_ShouldThrowException()
        {
            var newProduct = new Product()
            {
                OriginCountry = "Bulgaria",
                ProductName = "TestProduct",
                ProductCode = "AB12C",
                Price = -1m,
                Quantity = 100,
                Description = "Anything for description"
            };

            var ex = Assert.ThrowsAsync<ValidationException>(async () => await productsManager.AddAsync(newProduct));
            var actual = await dbContext.Products.FirstOrDefaultAsync(c => c.ProductCode == newProduct.ProductCode);

            Assert.IsNull(actual);
            Assert.That(ex?.Message, Is.EqualTo("Invalid product!"));
        }

        [Test]
        public async Task DeleteProductAsync_WithValidProductCode_ShouldRemoveProductFromDb()
        {
            // Arrange
            var newProduct = new Product()
            {
                OriginCountry = "Bulgaria",
                ProductName = "TestProduct",
                ProductCode = "AB12C",
                Price = 1.25m,
                Quantity = 100,
                Description = "Anything for description"
            };

            await productsManager.AddAsync(newProduct);

            // Act
            await productsManager.DeleteAsync(newProduct.ProductCode);

            // Assert
            var productInTheDb = await dbContext.Products.FirstOrDefaultAsync(x => x.ProductCode == newProduct.ProductCode);

            Assert.IsNull(productInTheDb);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("     ")]
        public async Task DeleteProductAsync_TryToDeleteWithNullOrWhiteSpaceProductCode_ShouldThrowException(string invalidCode)
        {
            // Act
            var exception = Assert.ThrowsAsync<ArgumentException>(() => productsManager.DeleteAsync(invalidCode));

            // Assert
            Assert.That(exception.Message, Is.EqualTo("Product code cannot be empty."));
        }

        [Test]
        public async Task GetAllAsync_WhenProductsExist_ShouldReturnAllProducts()
        {
            // Arrange
            var firstProduct = new Product()
            {
                OriginCountry = "Bulgaria",
                ProductName = "TestProduct",
                ProductCode = "AB12C",
                Price = 88m,
                Quantity = 100,
                Description = "Anything for description"
            };

            var secondProduct = new Product()
            {
                OriginCountry = "Germany",
                ProductName = "TestProduct Second",
                ProductCode = "DA12C",
                Price = 33m,
                Quantity = 100,
                Description = "Anything for description"
            };

            await productsManager.AddAsync(firstProduct);
            await productsManager.AddAsync(secondProduct);

            // Act
            var result = await productsManager.GetAllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(2));

            var firstItem = result.FirstOrDefault(x => x.ProductCode == firstProduct.ProductCode);

            Assert.NotNull(firstItem);
            Assert.That(firstItem.ProductName, Is.EqualTo(firstProduct.ProductName));
            Assert.That(firstItem.Description, Is.EqualTo(firstProduct.Description));
            Assert.That(firstItem.Price, Is.EqualTo(firstProduct.Price));
            Assert.That(firstItem.Quantity, Is.EqualTo(firstProduct.Quantity));
            Assert.That(firstItem.OriginCountry, Is.EqualTo(firstProduct.OriginCountry));
            Assert.That(firstItem.ProductCode, Is.EqualTo(firstProduct.ProductCode));

            var secondItem = result.FirstOrDefault(x => x.ProductName == secondProduct.ProductName);

            Assert.NotNull(secondItem);

            Assert.That(secondItem.ProductName, Is.EqualTo(secondProduct.ProductName));
            Assert.That(secondItem.Description, Is.EqualTo(secondProduct.Description));
            Assert.That(secondItem.Price, Is.EqualTo(secondProduct.Price));
            Assert.That(secondItem.Quantity, Is.EqualTo(secondProduct.Quantity));
            Assert.That(secondItem.OriginCountry, Is.EqualTo(secondProduct.OriginCountry));
            Assert.That(secondItem.ProductCode, Is.EqualTo(secondProduct.ProductCode));
        }

        [Test]
        public async Task GetAllAsync_WhenNoProductsExist_ShouldThrowKeyNotFoundException()
        {
            // Act and Assert
            var exception = Assert.ThrowsAsync<KeyNotFoundException>(() => productsManager.GetAllAsync());

            Assert.That(exception.Message, Is.EqualTo("No product found."));
        }

        [Test]
        public async Task SearchByOriginCountry_WithExistingOriginCountry_ShouldReturnMatchingProducts()
        {
            // Arrange
            var firstProduct = new Product()
            {
                OriginCountry = "Bulgaria",
                ProductName = "TestProduct",
                ProductCode = "AB12C",
                Price = 88m,
                Quantity = 100,
                Description = "Anything for description"
            };

            var secondProduct = new Product()
            {
                OriginCountry = "Germany",
                ProductName = "TestProduct Second",
                ProductCode = "DA12C",
                Price = 33m,
                Quantity = 100,
                Description = "Anything for description"
            };

            await productsManager.AddAsync(firstProduct);
            await productsManager.AddAsync(secondProduct);


            // Act
            var result = await productsManager.SearchByOriginCountry(firstProduct.OriginCountry);

            // Assert
            Assert.That(result.Count(), Is.EqualTo(1));

            var resultProduct = result.First();

            Assert.That(resultProduct.ProductName, Is.EqualTo(firstProduct.ProductName));
            Assert.That(resultProduct.Description, Is.EqualTo(firstProduct.Description));
            Assert.That(resultProduct.Price, Is.EqualTo(firstProduct.Price));
            Assert.That(resultProduct.Quantity, Is.EqualTo(firstProduct.Quantity));
            Assert.That(resultProduct.OriginCountry, Is.EqualTo(firstProduct.OriginCountry));
            Assert.That(resultProduct.ProductCode, Is.EqualTo(firstProduct.ProductCode));
        }

        [Test]
        public async Task SearchByOriginCountryAsync_WithNonExistingOriginCountry_ShouldThrowKeyNotFoundException()
        {
            // Act and Assert
            var exception = Assert.ThrowsAsync<KeyNotFoundException>(() => productsManager.SearchByOriginCountry("NON_EXISTING_COUNTRY"));

            Assert.That(exception.Message, Is.EqualTo("No product found with the given country of origin."));
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("    ")]
        public async Task SearchByOriginCountryAsync_WithInvalidOriginCountry_ShouldThrowArgumentException(string invalidCountryName)
        {
            // Act and Assert
            var exception = Assert.ThrowsAsync<ArgumentException>(() => productsManager.SearchByOriginCountry(invalidCountryName));

            Assert.That(exception.Message, Is.EqualTo("Country name cannot be empty."));
        }

        [Test]
        public async Task GetSpecificAsync_WithValidProductCode_ShouldReturnProduct()
        {
            // Arrange
            var firstProduct = new Product()
            {
                OriginCountry = "Bulgaria",
                ProductName = "TestProduct",
                ProductCode = "AB12C",
                Price = 88m,
                Quantity = 100,
                Description = "Anything for description"
            };

            var secondProduct = new Product()
            {
                OriginCountry = "Germany",
                ProductName = "TestProduct Second",
                ProductCode = "DA12C",
                Price = 33m,
                Quantity = 100,
                Description = "Anything for description"
            };

            await productsManager.AddAsync(firstProduct);
            await productsManager.AddAsync(secondProduct);

            // Act
            var result = await productsManager.GetSpecificAsync(secondProduct.ProductCode);

            // Assert
            Assert.NotNull(result);

            Assert.That(result.ProductName, Is.EqualTo(secondProduct.ProductName));
            Assert.That(result.Description, Is.EqualTo(secondProduct.Description));
            Assert.That(result.Price, Is.EqualTo(secondProduct.Price));
            Assert.That(result.Quantity, Is.EqualTo(secondProduct.Quantity));
            Assert.That(result.OriginCountry, Is.EqualTo(secondProduct.OriginCountry));
            Assert.That(result.ProductCode, Is.EqualTo(secondProduct.ProductCode));
        }

        [Test]
        public async Task GetSpecificAsync_WithInvalidProductCode_ShouldThrowKeyNotFoundException()
        {
            // Arrange
            const string invalidProductCode = "NON_VALID_CODE";

            // Act and Assert
            var exception = Assert.ThrowsAsync<KeyNotFoundException>(() => productsManager.GetSpecificAsync(invalidProductCode));

            Assert.That(exception.Message, Is.EqualTo($"No product found with product code: {invalidProductCode}"));
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("    ")]
        public async Task GetSpecificAsync_WithInvalidProductCode_ShouldThrowArgumentException(string invalidCode)
        {
            // Act and Assert
            var exception = Assert.ThrowsAsync<ArgumentException>(() => productsManager.GetSpecificAsync(invalidCode));

            Assert.That(exception.Message, Is.EqualTo("Product code cannot be empty."));
        }

        [Test]
        public async Task UpdateAsync_WithValidProduct_ShouldUpdateProduct()
        {
            // Arrange
            var firstProduct = new Product()
            {
                OriginCountry = "Bulgaria",
                ProductName = "TestProduct",
                ProductCode = "AB12C",
                Price = 88m,
                Quantity = 100,
                Description = "Anything for description"
            };

            var secondProduct = new Product()
            {
                OriginCountry = "Germany",
                ProductName = "TestProduct Second",
                ProductCode = "DA12C",
                Price = 33m,
                Quantity = 100,
                Description = "Anything for description"
            };

            await productsManager.AddAsync(firstProduct);
            await productsManager.AddAsync(secondProduct);

            // Act
            firstProduct.ProductName = "UPDATED NAME!";

            await productsManager.UpdateAsync(firstProduct);

            // Assert
            var productInTheDB = await productsManager.GetSpecificAsync(firstProduct.ProductCode);

            Assert.NotNull(productInTheDB);

            Assert.That(productInTheDB.ProductName, Is.EqualTo(firstProduct.ProductName));
            Assert.That(productInTheDB.Description, Is.EqualTo(firstProduct.Description));
            Assert.That(productInTheDB.Price, Is.EqualTo(firstProduct.Price));
            Assert.That(productInTheDB.Quantity, Is.EqualTo(firstProduct.Quantity));
            Assert.That(productInTheDB.OriginCountry, Is.EqualTo(firstProduct.OriginCountry));
            Assert.That(productInTheDB.ProductCode, Is.EqualTo(firstProduct.ProductCode));
        }

        [Test]
        public async Task UpdateAsync_WithInvalidProduct_ShouldThrowValidationException()
        {
            // Arrange
            var invalidProduct = new Product()
            {
                OriginCountry = "Germany",
                ProductName = "TestProduct Second",
                ProductCode = "DA12C",
                Price = -300m,
                Quantity = 100,
                Description = "Anything for description"
            };

            // Act
            var exception = Assert.ThrowsAsync<ValidationException>(() => productsManager.UpdateAsync(invalidProduct));

            Assert.That(exception.Message, Is.EqualTo("Invalid product!"));
        }

        [Test]
        public async Task UpdateAsync_WithNullProduct_ShouldThrowValidationException()
        {
            // Act
            var exception = Assert.ThrowsAsync<ValidationException>(() => productsManager.UpdateAsync(null));

            Assert.That(exception.Message, Is.EqualTo("Invalid product!"));
        }
    }
}
