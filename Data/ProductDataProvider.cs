using WiredBrainCoffee.CustomersApp.Models;

namespace WiredBrainCoffee.CustomersApp.Data
{
    public class ProductDataProvider : IProductDataProvider
    {
        public async Task<IEnumerable<Product>?> GetAllAsync()
        {
            await Task.Delay(100);

            return new List<Product>
            {
                new() {Name = "Cappucino", Description = "Espresso with milk and foam"},
                new() {Name = "Doppio", Description = "Double espresso"},
                new() {Name = "Espresso", Description = "Pure coffee to keep you awake!"},
                new() {Name = "Latte", Description = "Cappucino with more steamed milk rather than foam"},
                new() {Name = "Macchiato", Description = "Espresso with milk foam"},
                new() {Name = "Mocha", Description = "Espresso with hot chocolate and milk foam"}
            };
        }
    }
}
