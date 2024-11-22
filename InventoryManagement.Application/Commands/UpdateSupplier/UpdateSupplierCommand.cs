using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateSupplier
{
    public class UpdateSupplierCommand : IRequest<ResultViewModel>
    {
        public int IdSupplier { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
