using InventoryManagement.Core.Entities;

namespace InventoryManagement.Application.Models
{
    public class ProductsViewModel
    {
        public ProductsViewModel(int id, string name, string description, decimal price, int quantityInStock, DateTime createdAt, bool isDeleted, int idCategory, string nameCategory, int idSupplier, string nameSupplier)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            CreatedAt = createdAt;
            IsDeleted = isDeleted;
            IdCategory = idCategory;
            NameCategory = nameCategory;
            IdSupplier = idSupplier;
            NameSupplier = nameSupplier;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityInStock { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsDeleted { get; private set; }
        public int IdCategory { get; private set; }
        public string NameCategory { get; private set; }
        public int IdSupplier { get; private set; }
        public string NameSupplier { get; private set; }

        public static ProductsViewModel FromEntity(Product product)
            => new(
                product.Id,
                product.Name,
                product.Description,
                product.Price,
                product.QuantityInStock,
                product.CreatedAt,
                product.IsDeleted,
                product.Category.Id,
                product.Category.Name,
                product.Supplier.Id,
                product.Supplier.Name);
    }
}
