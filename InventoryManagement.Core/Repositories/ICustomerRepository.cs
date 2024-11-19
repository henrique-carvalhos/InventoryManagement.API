using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetbyId(int id);
        Task<List<Customer>> GetAll(string search);
        Task<int> Add(Customer customer);
        Task Update(Customer customer);
    }
}
