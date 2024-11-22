using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Product?> GetbyId(int id);
        Task<List<Product>> GetAll(string search);
        Task<int> Add(Product product);
        Task Update(Product product);
    }
}
