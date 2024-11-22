using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteSupplier
{
    public class DeleteSupplierCommand : IRequest<ResultViewModel>
    {
        public DeleteSupplierCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
