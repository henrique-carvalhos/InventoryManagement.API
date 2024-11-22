using InventoryManagement.Application.Models;
using InventoryManagement.Core.Entities;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSupplier
{
    public class InsertSupplierCommand : IRequest<ResultViewModel<int>>
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Supplier ToEntity()
            => new(Name, Contact, Email, Address);
    }
}
