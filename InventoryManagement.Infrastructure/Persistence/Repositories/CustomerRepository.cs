using InventoryManagement.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly InventoryManagementDbContext _context;
        public CustomerRepository(InventoryManagementDbContext context)
        {
            _context = context;
        }
    }
}
