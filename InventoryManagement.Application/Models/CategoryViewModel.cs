using InventoryManagement.Core.Entities;

namespace InventoryManagement.Application.Models
{
    internal class CategoryViewModel
    {
        public CategoryViewModel(int id, string name, string description, bool isDeleted, List<Product> products)
        {
            Id = id;
            Name = name;
            Description = description;
            IsDeleted = isDeleted;
            Products = products;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<Product> Products { get; private set; }

        public static CategoryViewModel FromEntity(Category category)
        {
            var product = category.Products.ToList();

            return new CategoryViewModel(category.Id, category.Name, category.Description, category.IsDeleted, product);
        }
    }
}
