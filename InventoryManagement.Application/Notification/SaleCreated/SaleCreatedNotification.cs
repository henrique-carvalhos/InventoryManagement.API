using MediatR;

namespace InventoryManagement.Application.Notification.SaleCreated
{
    public class SaleCreatedNotification : INotification
    {
        public SaleCreatedNotification(int id, decimal totalAmount, int idCustomer)
        {
            Id = id;
            TotalAmount = totalAmount;
            IdCustomer = idCustomer;
        }

        public int Id { get; private set; }
        public decimal TotalAmount { get; private set; }
        public int IdCustomer { get; private set; }
    }
}
