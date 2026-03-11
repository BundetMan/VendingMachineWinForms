using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.FactoryMethodPattern;

public class Snack : Product
{

    public override string ToString() =>
        $"[Snack] {Name} | Price: {Price:C} | Stock: {Stock} | Category: {Category}";
}
