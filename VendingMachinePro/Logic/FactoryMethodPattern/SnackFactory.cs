using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.FactoryMethodPattern;

public class SnackFactory : ProductFactory
{
    public override IProduct Create(string name, decimal price, int stock, string category, string imagePath)
    {
        return new Snack
        {
            Name = name,
            Price = price,
            Stock = stock,
            Category = "Snack",
            ImagePath = imagePath
        };
    }
}
