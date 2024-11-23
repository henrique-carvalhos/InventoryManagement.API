using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Persistence.Repositories
{
    public class SaleItemRepository : ISaleItemRepository
    {
        private readonly InventoryManagementDbContext _context;
        public SaleItemRepository(InventoryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(SaleItem item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();

            return item.Id;
        }

        public async Task<List<SaleItem>> GetAll(string search)
        {
            var saleItem = await _context.SaleItems
                .Include(p => p.Product)
                .Include(s => s.Sale)
                .Where(u => !u.IsDeleted && (search == "" || u.Product.Description.Contains(search)))
                .ToListAsync();

            return saleItem;
        }

        public async Task<SaleItem?> GetbyId(int id)
        {
            return await _context.SaleItems
                .Include(p => p.Product)
                .Include(s => s.Sale)
                .SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(SaleItem item)
        {
            _context.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
