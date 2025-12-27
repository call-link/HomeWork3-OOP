namespace OnlineStore.Models;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; protected set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual string GetProductDetails()
    {
        return $"Product: {Name}, Price: {Price:C}";
    }
}
