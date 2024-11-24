using MediatR;

namespace InventoryManagement.Application.Notification.SaleCreated
{
    public class CustomerNotificationHandler : INotificationHandler<SaleCreatedNotification>
    {
        public Task Handle(SaleCreatedNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Notificando o cliente código: {notification.IdCustomer} sobre a compra nº: {notification.Id}, no valor de R$ {notification.TotalAmount}");

            return Task.CompletedTask;
        }
    }
}
