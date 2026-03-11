
using VendingMachinePro.Logic.FactoryMethodPattern;
using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.Data
{
    internal class DataSeeder
    {
        public static void Seed()
        {
            var db = DbcontextManager.Instance;

            if (!db.Products.Any())
            {
                ProductFactory drinkFactory = new DrinkFactory();
                ProductFactory snackFactory = new SnackFactory();

                db.Products.AddRange(new List<Product>
                {
                    (Product)drinkFactory.Create("Coca-Cola", 2500, 10, "drink", ""),
                    (Product)drinkFactory.Create("Pepsi", 2500, 10, "drink", ""),
                    (Product)drinkFactory.Create("Water", 1000, 15, "drink", ""),
                    (Product)snackFactory.Create("Chips", 3000, 20, "snake", ""),
                    (Product) snackFactory.Create("Lays", 3000, 12, "snake", ""),
                });

                db.SaveChanges();
            }
        }
    }
}
