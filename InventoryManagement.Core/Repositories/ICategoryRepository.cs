using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category?> GetbyId(int id);
        Task<List<Category>> GetAll(string search);
        Task<int> Add(Category category);
        Task Update(Category category);
    }
}
