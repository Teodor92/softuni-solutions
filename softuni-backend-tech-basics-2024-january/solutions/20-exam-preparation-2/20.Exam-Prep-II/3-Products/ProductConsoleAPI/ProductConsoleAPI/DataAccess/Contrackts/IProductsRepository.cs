using ProductConsoleAPI.Data.Models;

namespace ProductConsoleAPI.DataAccess.Contrackts
{
    public interface IProductsRepository
    {
        Task<Product> GetProductByProductCodeAsync(string productCode);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<IEnumerable<Product>> SearchProductsByOriginCountry(string originCountry);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(string productCode);
    }
}
