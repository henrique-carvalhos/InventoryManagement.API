using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<List<Product>> GetAll(string search)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
