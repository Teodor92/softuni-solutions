using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Store;

public class Shop
{
    public string AddAndGetBoxes(string[] products)
    {
        List<Box> boxList = new();
        foreach (string product in products)
        {
            string[] data = product.Split();

            long serialNumber = long.Parse(data[0]);
            string name = data[1];
            int itemQty = int.Parse(data[2]);
            decimal price = decimal.Parse(data[3]);

            decimal boxPrice = price * itemQty;
            Item newItem = new()
            {
                Name = name,
                Price = price
            };

            Box newBox = new()
            {
                SerialNumber = serialNumber,
                Item = newItem,
                ItemQuantity = itemQty,
                BoxPrice = boxPrice
            };

            boxList.Add(newBox);
        }

        StringBuilder sb = new();
        foreach (Box box in boxList.OrderByDescending(box => box.BoxPrice))
        {
            sb.AppendLine(box.SerialNumber.ToString());
            sb.AppendLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
            sb.AppendLine($"-- ${box.BoxPrice:f2}");
        }

        return sb.ToString().Trim();
    }
}
