using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Repositories
{
    public interface ISupplierRepository
    {
        Task<Supplier?> GetbyId(int id);
        Task<List<Supplier>> GetAll(string search);
        Task<int> Add(Supplier supplier);
        Task Update(Supplier supplier);
    }
}
