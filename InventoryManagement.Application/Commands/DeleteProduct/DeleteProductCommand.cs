using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<ResultViewModel>
    {
        public DeleteProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
