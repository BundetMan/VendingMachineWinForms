namespace VendingMachinePro.Logic.StrategyPattern;

public class RielPayment : IPaymentStrategy
{
    public decimal InsertMoney(decimal currentMoney, decimal amount)
    {
        return currentMoney + amount;
    }
}
