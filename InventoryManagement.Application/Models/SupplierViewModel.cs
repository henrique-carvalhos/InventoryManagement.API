using InventoryManagement.Core.Entities;

namespace InventoryManagement.Application.Models
{
    public class SupplierViewModel
    {
        public SupplierViewModel(int id, string name, string contact, string email, string address, DateTime createdAt, bool isDeleted, List<Product> products)
        {
            Id = id;
            Name = name;
            Contact = contact;
            Email = email;
            Address = address;
            CreatedAt = createdAt;
            IsDeleted = isDeleted;
            Products = products;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Contact { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<Product> Products { get; private set; }

        public static SupplierViewModel FromEntity(Supplier supplier)
        {
            var products = supplier.Products.ToList();

            return new SupplierViewModel(supplier.Id, supplier.Name, supplier.Contact, supplier.Email, supplier.Address, supplier.CreatedAt, supplier.IsDeleted, products);
        }
    }
}
