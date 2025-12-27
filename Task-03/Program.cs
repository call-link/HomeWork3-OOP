using OnlineStore.Models;
using OnlineStore.Interfaces;

List<Product> products = new List<Product>();

products.Add(new Electronic("Laptop", 50000, 24));
products.Add(new Clothing("T-Shirt", 1200, "L", "Cotton"));
products.Add(new Electronic("Smartphone", 30000, 12));

foreach (Product product in products)
{
    // اگر محصول قابلیت تخفیف داشت
    if (product is IDiscountable discountable)
    {
        discountable.ApplyDiscount(10);
    }

    Console.WriteLine(product.GetProductDetails());
}
