namespace OnlineShop;

public class Electronic : Product, IDiscountable
{
    public string Brand { get; set; }

    public Electronic(string name, decimal price, string brand)
        : base(name, price)
    {
        Brand = brand;
    }

    public void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public override string GetProductDetails()
    {
        return $"Electronic product: {Name} | brand: {Brand} | price: {Price} $$ ";
    }
}
