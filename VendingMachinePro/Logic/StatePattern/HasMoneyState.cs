using VendingMachinePro.Logic.Data;
using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.StatePattern;

public class HasMoneyState : IVendingState
{
    public void InsertMoney(VendingMachine machine, decimal amount)
    {
        machine.AddMoney(amount);
    }

    public void SelectProduct(VendingMachine machine, string productId)
    {
        var db = DbcontextManager.Instance;
        var product = db.Products.Find(productId);

        if (product == null || product.Stock <= 0)
        {
            MessageBox.Show("Product unavailable.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (machine.CurrentMoney >= product.Price)
        {
            var sale = new Sale
            {
                ProductId = product.Id,
                Quantity = 1,
                Amount = product.Price,
                Date = DateTime.Now
            };
            db.Sales.Add(sale);

            // Dispense handles stock decrement and SaveChanges internally
            machine.Dispense(product);
            MessageBox.Show($"Enjoy your {product.Name}!", "Purchase Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Only reset state if balance becomes 0
            if (machine.CurrentMoney == 0)
            {
                machine.SetState(new WaitingState());
            }
        }
        else
        {
            MessageBox.Show($"Not enough money. Price: {product.Price}, Balance: {machine.CurrentMoney:C}",
                "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}