namespace _03.StoreBoxes
{
    public class Item
    {
        //public Item(string name, decimal price)
        //{
        //    Name = name;
        //    Price = price;
        //}

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        //public Box(string serialNumber, Item item, int itemQuantity)
        //{
        //    SerialNumber = serialNumber;
        //    Item = item;
        //    ItemQuantity = itemQuantity;
        //    PriceForABox = item.Price * itemQuantity;
        //}

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForABox { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] data = command.Split(" ");
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                //Item currentItem = new Item(itemName, itemPrice);
                //Box currentBox = new Box(serialNumber, currentItem, itemQuantity);

                Item currentItem = new Item
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                Box currentBox = new Box
                {
                    SerialNumber = serialNumber,
                    Item = currentItem,
                    ItemQuantity = itemQuantity,
                    PriceForABox = itemQuantity * currentItem.Price,
                };

                boxes.Add(currentBox);

                command = Console.ReadLine();
            }

            boxes = boxes
                .OrderByDescending(box => box.PriceForABox)
                .ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }
}
