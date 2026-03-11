using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.FactoryMethodPattern;

public class Drink : Product
{
    public override string ToString() =>
        $"[Drink] {Name} | Price: {Price:C} | Stock: {Stock} | Category: {Category}";
}