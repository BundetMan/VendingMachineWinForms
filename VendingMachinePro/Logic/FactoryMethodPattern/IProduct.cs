namespace VendingMachinePro.Logic.FactoryMethodPattern;

public interface IProduct
{
    string Id { get; set; }
    string Name { get; set; }
    decimal Price { get; set; }
    int Stock { get; set; }
    string Category { get; set; }
    string ImagePath { get; set; }
}
