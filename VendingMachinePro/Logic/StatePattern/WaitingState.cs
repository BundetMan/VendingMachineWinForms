using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.StatePattern;

public class WaitingState : IVendingState
{
    public void InsertMoney(VendingMachine machine, decimal amount)
    {
        machine.AddMoney(amount);
        machine.SetState(new HasMoneyState());
    }

    public void SelectProduct(VendingMachine machine, string productId)
    {
        MessageBox.Show("Please insert money first.", "No Balance",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}