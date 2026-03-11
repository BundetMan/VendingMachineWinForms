using VendingMachinePro.Logic.FactoryMethodPattern;

namespace VendingMachinePro.Models;

public class Product : IProduct
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Category { get; set; } = default!;
    public string ImagePath { get; set; } = default!;
}
