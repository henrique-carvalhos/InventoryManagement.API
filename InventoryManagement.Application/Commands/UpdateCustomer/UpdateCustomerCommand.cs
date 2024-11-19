using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest<ResultViewModel>
    {
        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
