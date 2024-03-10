using ProductConsoleAPI.Data.Models;

namespace ProductConsoleAPI.Business.Contracts
{
    public interface IProductsManager
    {
        Task AddAsync(Product product);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> SearchByOriginCountry(string originCountry);
        Task<Product> GetSpecificAsync(string productCode);
        Task UpdateAsync(Product product);
        Task DeleteAsync(string productCode);
    }
}
