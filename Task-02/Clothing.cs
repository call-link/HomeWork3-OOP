namespace OnlineShop;

public class Clothing : Product
{
    public string Material { get; set; }
    public string Size { get; set; }

    public Clothing(string name, decimal price, string material, string size)
        : base(name, price)
    {
        Material = material;
        Size = size;
    }

    public override string GetProductDetails()
    {
        return $"Clothing product: {Name} | material: {Material} | size: {Size} | price: {Price} $$";
    }
}
