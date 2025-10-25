using InventoryApp.Domain;

namespace InventoryApp.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<int> InsertAsync(Product p);
        Task<bool> UpdateAsync(Product p);
        Task<bool> DeleteAsync(int id);
    }
}
