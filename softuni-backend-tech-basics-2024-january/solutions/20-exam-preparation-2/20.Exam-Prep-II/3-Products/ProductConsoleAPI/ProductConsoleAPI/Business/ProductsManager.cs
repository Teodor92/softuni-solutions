using ProductConsoleAPI.Business.Contracts;
using ProductConsoleAPI.Data.Models;
using ProductConsoleAPI.DataAccess.Contrackts;
using System.ComponentModel.DataAnnotations;

namespace ProductConsoleAPI.Business
{
    public class ProductsManager : IProductsManager
    {
        private readonly IProductsRepository repository;

        public ProductsManager(IProductsRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddAsync(Product product)
        {
            if (!IsValid(product))
            {
                throw new ValidationException("Invalid product!");
            }
            await repository.AddProductAsync(product);
        }

        public Task DeleteAsync(string productCode)
        {
            if (string.IsNullOrWhiteSpace(productCode))
            {
                throw new ArgumentException("Product code cannot be empty.");
            }

            return repository.DeleteProductAsync(productCode);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await repository.GetAllProductsAsync();

            if (!products.Any())
            {
                throw new KeyNotFoundException("No product found.");
            }

            return products;
        }

        public async Task<Product> GetSpecificAsync(string productCode)
        {
            if (string.IsNullOrWhiteSpace(productCode))
            {
                throw new ArgumentException("Product code cannot be empty.");
            }

            var product = await repository.GetProductByProductCodeAsync(productCode);

            if (product == null)
            {
                throw new KeyNotFoundException($"No product found with product code: {productCode}");
            }

            return product;
        }

        public async Task<IEnumerable<Product>> SearchByOriginCountry(string originCountry)
        {
            if (string.IsNullOrWhiteSpace(originCountry))
            {
                throw new ArgumentException("Country name cannot be empty.");
            }

            var products = await repository.SearchProductsByOriginCountry(originCountry);

            if (products == null || !products.Any())
            {
                throw new KeyNotFoundException("No product found with the given country of origin.");
            }

            return products;
        }

        public async Task UpdateAsync(Product product)
        {
            if (!IsValid(product))
            {
                throw new ValidationException("Invalid product!");
            }

            await repository.UpdateProductAsync(product);
        }

        private bool IsValid(Product product)
        {
            if (product == null)
            {
                return false;
            }

            var validateResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(product);

            if (!Validator.TryValidateObject(product, validationContext, validateResults, true))
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
