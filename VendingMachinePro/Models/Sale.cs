namespace VendingMachinePro.Models;

public class Sale
{
    public int Id { get; set; }              // Primary key
    public string ProductId { get; set; }       // Foreign key to Product
    public Product Product { get; set; }     // Navigation property

    public int Quantity { get; set; }        // How many units sold
    public decimal Amount { get; set; }      // Total price for this sale
    public DateTime Date { get; set; }       // When the sale happened
}
