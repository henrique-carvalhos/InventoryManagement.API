using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryManagementDbContext _context;
        public ProductRepository(InventoryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product.Id;
        }

        public async Task<List<Product>> GetAll(string search)
        {
            var product = await _context.Products
                .Include(s => s.Supplier)
                .Include(c => c.Category)
                .Where(u => !u.IsDeleted && (search == "" || u.Name.Contains(search)))
                .ToListAsync();

            return product;
        }

        public async Task<Product?> GetbyId(int id)
        {
            return await _context.Products
                .Include(s => s.Supplier)
                .Include(c => c.Category)
                .SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task Update(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
