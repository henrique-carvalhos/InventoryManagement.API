using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly InventoryManagementDbContext _context;
        public CustomerRepository(InventoryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();

            return customer.Id;
        }

        public async Task<List<Customer>> GetAll(string search)
        {
            var customers = await _context.Customers
                .Where(u => !u.IsDeleted && (search == "" || u.Name.Contains(search)))
                .ToListAsync();

            return customers;
        }

        public async Task<Customer?> GetbyId(int id)
        {
            return await _context.Customers
                .SingleOrDefaultAsync(customer => customer.Id == id);
        }

        public async Task Update(Customer customer)
        {
            _context.Update(customer);
            await _context.SaveChangesAsync();
        }
    }
}
