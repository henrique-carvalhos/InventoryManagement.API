using InventoryManagement.Application.Models;
using InventoryManagement.Core.Entities;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertCustomer
{
    public class InsertCustomerCommand : IRequest<ResultViewModel<int>>
    {
        public string Name { get;  set; }
        public string Email { get;  set; }
        public string Phone { get;  set; }

        public Customer ToEntity()
            => new(Name, Email, Phone);
    }
}
