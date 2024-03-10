using ProductConsoleAPI.Business.Contracts;
using ProductConsoleAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsoleAPI.Business
{
    public class Engine : IEngine
    {
        public async Task Run(IProductsManager productManager)
        {
            bool exitRequested = false;
            while (!exitRequested)
            {
                Console.WriteLine($"{Environment.NewLine}Choose an option:");
                Console.WriteLine("1: Add Product");
                Console.WriteLine("2: Delete Product");
                Console.WriteLine("3: List All Products");
                Console.WriteLine("4: Update Product");
                Console.WriteLine("5: Find Product by country of origin");
                Console.WriteLine("X: Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await AddProduct(productManager);
                        break;
                    case "2":
                        await DeleteProduct(productManager);
                        break;
                    case "3":
                        await ListAllProducts(productManager);
                        break;
                    case "4":
                        await UpdateProduct(productManager);
                        break;
                    case "5":
                        await FindProductByOriginCountry(productManager);
                        break;
                    case "X":
                    case "x":
                        exitRequested = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                static async Task AddProduct(IProductsManager productsManager)
                {
                    Console.WriteLine("Adding a new product:");

                    Console.Write("Enter product code: ");
                    var productCode = Console.ReadLine();

                    Console.Write("Enter product name: ");
                    var productName = Console.ReadLine();

                    Console.Write("Enter quantity: ");
                    var quantity = int.Parse(Console.ReadLine());

                    Console.Write("Enter price: ");
                    var price = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter country of origin: ");
                    var originCountry = Console.ReadLine();

                    Console.Write("Enter product description: ");
                    var description = Console.ReadLine();

                    var newProduct = new Product()
                    {
                        Quantity = quantity,
                        Description = description,
                        OriginCountry = originCountry,
                        ProductCode = productCode,
                        ProductName = productName,
                        Price = price
                    };

                    await productsManager.AddAsync(newProduct);
                    Console.WriteLine("Product added successfully.");
                }

                static async Task DeleteProduct(IProductsManager productsManager)
                {
                    Console.Write("Enter the code of the product to delete it: ");
                    string productCode = Console.ReadLine();
                    await productsManager.DeleteAsync(productCode);
                    Console.WriteLine("Product deleted successfully.");
                }

                static async Task ListAllProducts(IProductsManager productsManager)
                {
                    var products = await productsManager.GetAllAsync();
                    if (products.Any())
                    {
                        foreach (var product in products)
                        {
                            Console.WriteLine($"Code: {product.ProductCode}, Name: {product.ProductName}, Country of origin: {product.OriginCountry}, Quantity: {product.Quantity}, Price: {product.Price:F2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No products available.");
                    }
                }

                static async Task UpdateProduct(IProductsManager productsManager)
                {
                    Console.Write("Enter the code of the product to update: ");
                    string productCode = Console.ReadLine();
                    var productToUpdate = await productsManager.GetSpecificAsync(productCode);
                    if (productToUpdate == null)
                    {
                        Console.WriteLine("Product not found.");
                        return;
                    }
                    
                    Console.Write("Enter new product name (leave blank to keep current): ");
                    var productName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(productName))
                    {
                        productToUpdate.ProductName = productName;
                    }

                    Console.Write("Enter actual quantity of the product (leave blank to keep current): ");
                    var quantityInput = Console.ReadLine();
                    if (int.TryParse(quantityInput, out int quantity))
                    {
                        productToUpdate.Quantity = quantity < 0 ? 0 : quantity;
                    }

                    Console.Write("Enter new price of the product (leave blank to keep current): ");
                    var priceInput = Console.ReadLine();
                    if (decimal.TryParse(priceInput, out decimal price))
                    {
                        productToUpdate.Price = price > 0 ? price : 0;
                    }

                    Console.Write("Enter new country of origin (leave blank to keep current): ");
                    var originCountry = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(originCountry))
                    {
                        productToUpdate.OriginCountry = originCountry;
                    }

                    Console.Write("Enter new description of the product (leave blank to keep current): ");
                    var description = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(description))
                    {
                        productToUpdate.Description = description;
                    }
                }

                static async Task FindProductByOriginCountry(IProductsManager productsManager)
                {
                    Console.Write("Enter the country of origin to find products: ");
                    string originCountry = Console.ReadLine();
                    var products = await productsManager.SearchByOriginCountry(originCountry);

                    if (products.Any())
                    {
                        foreach (var product in products)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Product name: {product.ProductName}, Price: {product.Price}, Quantity: {product.Quantity}");
                            Console.WriteLine($"--Country of origin: {product.OriginCountry}, Product code: {product.ProductCode}");
                            Console.WriteLine($"---Description: {product.Description}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No product found with the given country of origin.");
                    }
                }
            }
        }
    }
}
