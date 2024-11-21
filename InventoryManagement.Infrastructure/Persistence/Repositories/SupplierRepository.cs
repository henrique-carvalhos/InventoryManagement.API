using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Persistence.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly InventoryManagementDbContext _context;
        public SupplierRepository(InventoryManagementDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();

            return supplier.Id;
        }

        public async Task<List<Supplier>> GetAll(string search)
        {
            var suppliers = await _context.Suppliers
                .Where(u => !u.IsDeleted && (search == "" || u.Name.Contains(search)))
                .ToListAsync();

            return suppliers;
        }

        public async Task<Supplier?> GetbyId(int id)
        {
            return await _context.Suppliers
                .SingleOrDefaultAsync(s => s.Id == id);   
        }

        public async Task Update(Supplier supplier)
        {
            _context.Update(supplier);
            await _context.SaveChangesAsync();
        }
    }
}
