namespace InventoryManagement.Core.Entities
{
    public class Supplier : BaseEntity
    {
        public Supplier(string name, string contact, string email, string address)
        {
            Name = name;
            Contact = contact;
            Email = email;
            Address = address;

            Products = [];
        }

        public string Name { get; private set; }
        public string Contact { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }

        public List<Product> Products { get; set; }
    }
}
