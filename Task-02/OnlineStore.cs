namespace OnlineShop;

using System.Collections.Generic;

public class OnlineStore
{
    public List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void ShowProducts()
    {
        foreach (var product in Products)
        {
            Console.WriteLine(product.GetProductDetails());
        }
    }
}

