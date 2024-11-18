namespace InventoryManagement.Core.Entities
{
    public class Category : BaseEntity
    {
        public Category(string name, string description) : base()
        {
            Name = name;
            Description = description;

            Products = [];
        }

        public string Name { get; private set; }
        public string Description { get; private set; }

        public List<Product> Products { get; set; }

        public void Update(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
