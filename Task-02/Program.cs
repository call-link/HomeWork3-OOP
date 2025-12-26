using OnlineShop;
class Program
{
    static void Main()
    {
        OnlineStore store = new OnlineStore();

        Electronic laptop = new Electronic("Laptop", 50000000, "Dell");
        Clothing tshirt = new Clothing("T-Shirt", 500000, "Cotton", "L");

        // اعمال تخفیف فقط روی محصولات الکترونیکی
        laptop.ApplyDiscount(10);

        store.AddProduct(laptop);
        store.AddProduct(tshirt);

        store.ShowProducts();
    }
}
