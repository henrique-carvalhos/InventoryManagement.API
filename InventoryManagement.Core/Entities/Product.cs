namespace InventoryManagement.Core.Entities
{
    public class Product : BaseEntity
    {
        public Product(string name, string description, decimal price, int quantityInStock, int idCategory, int idSupplier) : base()
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;

            IdCategory = idCategory;
            IdSupplier = idSupplier;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityInStock { get; private set; }


        public int IdCategory { get; private set; }
        public Category Category { get; private set; }

        public int IdSupplier { get; private set; }
        public Supplier Supplier { get; private set; }

        public void Update(string name, string description, decimal price, int quantityInStock, int idCategory, int idSupplier)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            IdCategory = idCategory;
            IdSupplier = idSupplier;
        }
    }
}
