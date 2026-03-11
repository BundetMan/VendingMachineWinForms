using VendingMachinePro.Models;
namespace VendingMachinePro.Logic.StatePattern;

public interface IVendingState
{
    void InsertMoney(VendingMachine machine, decimal amount);
    void SelectProduct(VendingMachine machine, string productId);
}
