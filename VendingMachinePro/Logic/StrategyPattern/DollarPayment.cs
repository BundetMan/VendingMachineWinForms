namespace VendingMachinePro.Logic.StrategyPattern;

public class DollarPayment : IPaymentStrategy
{
    private const decimal ExchangeRate = 4000;

    public decimal InsertMoney(decimal currentMoney, decimal amount)
    {
        decimal riel = amount * ExchangeRate;
        return currentMoney + riel;
    }
}
