using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Category>> GetAll(string search)
        {
            var categories = await _dbContext.Categories
                .Where(u => !u.IsDeleted && (search == "" || u.Description.Contains(search)))
                .ToListAsync();

            return categories;
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
