using ProductConsoleAPI.Business;
using ProductConsoleAPI.Data.Models;
using System.Text.Json;

namespace ProductConsoleAPI.DataAccess
{
    public class DatabaseSeeder
    {
        public static async Task SeedDatabaseAsync(ProductsDbContext context, ProductsManager productsManager)
        {
            if (context.Products.Count() == 0)
            {
                string jsonFilePath = Path.Combine("Data", "Seed", "products.json");
                string jsonData = File.ReadAllText(jsonFilePath);

                var products = JsonSerializer.Deserialize<List<Product>>(jsonData);

                if (products != null)
                {
                    foreach (var product in products)
                    {
                        if (!context.Products.Any(c => c.ProductCode == product.ProductCode))
                        {
                            var newProduct = new Product()
                            {
                                ProductCode = product.ProductCode,
                                Description = product.Description,
                                OriginCountry = product.OriginCountry,
                                Price = product.Price,
                                ProductName = product.ProductName,
                                Quantity = product.Quantity
                            };
                            await productsManager.AddAsync(newProduct);
                        }
                    }

                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
