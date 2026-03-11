using System;
using System.Collections.Generic;
using VendingMachinePro.Logic.Data;
using VendingMachinePro.Logic.StatePattern;
using VendingMachinePro.Logic.StrategyPattern;

namespace VendingMachinePro.Models
{
    public class VendingMachine
    {
        private decimal _currentMoney;
        public decimal CurrentMoney => _currentMoney;

        private IVendingState _state;
        private IPaymentStrategy _paymentStrategy;

        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly object _observerLock = new object();
        private readonly object _lock = new object();

        public VendingMachine(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy ?? throw new ArgumentNullException(nameof(paymentStrategy));
            _state = new WaitingState();
        }

        public void SetState(IVendingState newState)
        {
            _state = newState ?? throw new ArgumentNullException(nameof(newState));
            Notify($"State changed to: {newState.GetType().Name}");
        }

        public void InsertMoney(decimal amount)
        {
            _state.InsertMoney(this, amount);
        }

        internal void AddMoney(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Money must be greater than zero.");

            _currentMoney = _paymentStrategy.InsertMoney(_currentMoney, amount);
            Notify($"Money inserted: {amount:C}");
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public void SelectProduct(string productId)
        {
            _state.SelectProduct(this, productId);
        }

        internal void Dispense(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            lock (_lock)
            {
                if (product.Stock <= 0)
                    throw new InvalidOperationException($"{product.Name} is out of stock.");

                if (_currentMoney < product.Price)
                    throw new InvalidOperationException("Not enough money.");

                var db = DbcontextManager.Instance;

                product.Stock--;
                db.SaveChanges();

                // Deduct only the product price
                _currentMoney -= product.Price;

                Notify($"Dispensed: {product.Name} | Balance: {_currentMoney:C}");
            }
        }

        public decimal CancelTransaction()
        {
            decimal refund = _currentMoney;
            _currentMoney = 0;

            Notify($"Transaction cancelled. Refund: {refund:C}");
            return refund;
        }

        public void AddObserver(IObserver observer)
        {
            if (observer == null)
                throw new ArgumentNullException(nameof(observer));

            lock (_observerLock)
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            lock (_observerLock)
            {
                _observers.Remove(observer);
            }
        }

        private void Notify(string message)
        {
            lock (_observerLock)
            {
                foreach (var observer in _observers)
                {
                    observer.Update(message);
                }
            }
        }
    }
}