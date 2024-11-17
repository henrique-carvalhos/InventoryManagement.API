using InventoryManagement.Core.Entities;

namespace InventoryManagement.Application.Models
{
    internal class CustomerViewModel
    {
        public CustomerViewModel(int id, string name, string email, string phone, bool isDeleted, DateTime createdAt, List<Sale> sales)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            IsDeleted = isDeleted;
            CreatedAt = createdAt;
            Sales = sales;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<Sale> Sales { get; private set; }

        public static CustomerViewModel FromEntity(Customer customer)
        {
            var sale = customer.Sales.ToList();

            return new CustomerViewModel(customer.Id, customer.Name, customer.Email, customer.Phone, customer.IsDeleted, customer.CreatedAt, sale);
        }
    }
}
