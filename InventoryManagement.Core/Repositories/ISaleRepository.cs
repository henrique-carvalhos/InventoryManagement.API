using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Repositories
{
    public interface ISaleRepository
    {
        Task<Sale?> GetbyId(int id);
        Task<List<Sale>> GetAll(string search);
        Task<int> Add(Sale sale);
        Task Update(Sale sale);
    }
}
