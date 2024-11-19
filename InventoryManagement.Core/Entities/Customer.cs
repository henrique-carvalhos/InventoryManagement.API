namespace InventoryManagement.Core.Entities
{
    public class Customer : BaseEntity
    {
        public Customer(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;

            Sales = [];
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public List<Sale> Sales { get; set; }

        public void Update(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
