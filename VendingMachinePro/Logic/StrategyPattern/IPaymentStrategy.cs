namespace VendingMachinePro.Logic.StrategyPattern;

public interface IPaymentStrategy
{
    decimal InsertMoney(decimal currentMoney, decimal amount);
}
