using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.FactoryMethodPattern;

public class DrinkFactory : ProductFactory
{
    public override IProduct Create(string name, decimal price, int stock, string category, string imagePath)
    {
        return new Drink
        {
            Name = name,
            Price = price,
            Stock = stock,
            Category = "Drink",
            ImagePath = imagePath
        };
    }
}
