using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.FactoryMethodPattern;

public abstract class ProductFactory
{
    public abstract IProduct Create(string name, decimal price, int stock , string category, string imagePath);
}
