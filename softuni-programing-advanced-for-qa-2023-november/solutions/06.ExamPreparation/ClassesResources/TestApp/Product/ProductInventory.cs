using System.Text;

namespace TestApp.Product;

public class ProductInventory
{
    private readonly List<Product> _products = new();

    public void AddProduct(string name, double price, int quantity)
    {
        Product newProduct = new()
        {
            Name = name, 
            Price = price, 
            Quantity = quantity,
        };
        
        this._products.Add(newProduct);
    }

    public string DisplayInventory()
    {
        StringBuilder sb = new();
        
        sb.AppendLine("Product Inventory:");
        foreach (Product product in this._products)
        {
            sb.AppendLine($"{product.Name} - Price: ${product.Price:f2} - Quantity: {product.Quantity}");
        }

        return sb.ToString().Trim();
    }

    public double CalculateTotalValue()
    {
        return this._products.Sum(product => product.Price * product.Quantity);
    }
}
