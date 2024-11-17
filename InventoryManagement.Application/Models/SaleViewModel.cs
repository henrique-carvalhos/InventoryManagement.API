using InventoryManagement.Core.Entities;

namespace InventoryManagement.Application.Models
{
    public class SaleViewModel
    {
        public SaleViewModel(int id, DateTime saleDate, decimal totalAmount, string customer, bool isDeleted, List<SaleItem> saleItems)
        {
            Id = id;
            SaleDate = saleDate;
            TotalAmount = totalAmount;
            Customer = customer;
            IsDeleted = isDeleted;
            SaleItems = saleItems;
        }

        public int Id { get; private set; }
        public DateTime SaleDate { get; private set; }
        public decimal TotalAmount { get; private set; }
        public string Customer { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<SaleItem> SaleItems { get; private set; }

        public static SaleViewModel FromEntity(Sale sale)
        {
            var saleItems = sale.SaleItems.ToList();

            return new SaleViewModel(sale.Id, sale.SaleDate, sale.TotalAmount, sale.Customer.Name, sale.IsDeleted, saleItems);
        }
    }
}
