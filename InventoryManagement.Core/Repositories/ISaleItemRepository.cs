using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Repositories
{
    public interface ISaleItemRepository
    {
        Task<SaleItem?> GetbyId(int id);
        Task<List<SaleItem>> GetAll(string search);
        Task<int> Add(SaleItem item);
        Task Update(SaleItem item);
    }
}
