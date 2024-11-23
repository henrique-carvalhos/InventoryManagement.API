using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure.Persistence.Repositories
{
    public class SaleItemRepository : ISaleRepository
    {
        public Task<int> Add(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Task<List<Sale>> GetAll(string search)
        {
            throw new NotImplementedException();
        }

        public Task<Sale?> GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
