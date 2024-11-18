using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly InventoryManagementDbContext _dbContext;
        public CategoryRepository(InventoryManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
            
            return category.Id;
        }

        public Task<List<Category>> GetAll(string search)
        {
            throw new NotImplementedException();
        }

        public async Task<Category?> GetbyId(int id)
        {
            return await _dbContext.Categories
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public Task Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
