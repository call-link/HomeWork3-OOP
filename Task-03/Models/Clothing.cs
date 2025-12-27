namespace OnlineStore.Models;

public class Clothing : Product
{
    public string Size { get; set; }
    public string Material { get; set; }

    public Clothing(string name, decimal price, string size, string material)
        : base(name, price)
    {
        Size = size;
        Material = material;
    }

    public override string GetProductDetails()
    {
        return $"Clothing: {Name}, Price: {Price:C}, Size: {Size}, Material: {Material}";
    }
}
