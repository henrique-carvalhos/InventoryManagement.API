using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteSaleItem
{
    public class DeleteSaleItemCommand : IRequest<ResultViewModel>
    {
        public DeleteSaleItemCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
