using OnlineStore.Interfaces;

namespace OnlineStore.Models;

public class Electronic : Product, IDiscountable
{
    public int WarrantyPeriod { get; set; }

    public Electronic(string name, decimal price, int warrantyPeriod)
        : base(name, price)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public override string GetProductDetails()
    {
        return $"Electronic: {Name}, Price: {Price:C}, Warranty: {WarrantyPeriod} months";
    }
}
