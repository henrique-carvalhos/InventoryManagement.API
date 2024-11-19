using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest<ResultViewModel>
    {
        public DeleteCustomerCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
