namespace TestApp.Store;

public class Box
{
    public Box()
    {
        this.Item = new();
    }

    public long SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal BoxPrice { get; set; }
}
