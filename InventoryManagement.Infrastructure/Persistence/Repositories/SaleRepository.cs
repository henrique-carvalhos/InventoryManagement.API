using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure.Persistence.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly InventoryManagementDbContext _context;
        public SaleRepository(InventoryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Sale sale)
        {
            _context.Sales.Add(sale);
            await _context.SaveChangesAsync();

            return sale.Id;
        }

        public async Task<List<Sale>> GetAll(string search)
        {
            var sales = await _context.Sales
                .Include(c => c.Customer)
                .Where(u => !u.IsDeleted)
                .ToListAsync();

            return sales;
        }

        public async Task<Sale?> GetbyId(int id)
        {
            return await _context.Sales
                .Include(c => c.Customer)
                .SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(Sale sale)
        {
            _context.Update(sale);
            await _context.SaveChangesAsync();
        }
    }
}
