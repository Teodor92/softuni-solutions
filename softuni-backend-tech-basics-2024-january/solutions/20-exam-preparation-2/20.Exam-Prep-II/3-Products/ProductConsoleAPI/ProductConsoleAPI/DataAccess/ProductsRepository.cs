using Microsoft.EntityFrameworkCore;
using ProductConsoleAPI.Data.Models;
using ProductConsoleAPI.DataAccess.Contrackts;

namespace ProductConsoleAPI.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsDbContext context;

        public ProductsRepository(ProductsDbContext context)
        {
            this.context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(string productCode)
        {
            var product = await context.Products.FirstOrDefaultAsync(p => p.ProductCode == productCode);
            if (product != null)
            {
                context.Products.Remove(product);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var products = await context.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProductByProductCodeAsync(string productCode)
        {
            var product = await context.Products.FirstOrDefaultAsync(p => p.ProductCode == productCode);
            return product;
        }

        public async Task<IEnumerable<Product>> SearchProductsByOriginCountry(string originCountry)
        {
            var product = await context.Products.Where(p => p.OriginCountry == originCountry).ToListAsync();
            return product;
        }

        public async Task UpdateProductAsync(Product product)
        {
            context.Products.Update(product);
            await context.SaveChangesAsync();
        }
    }
}
