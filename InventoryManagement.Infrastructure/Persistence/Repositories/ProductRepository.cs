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
        public Task<int> Add(Product product)
        {
            throw new NotImplementedException();
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
