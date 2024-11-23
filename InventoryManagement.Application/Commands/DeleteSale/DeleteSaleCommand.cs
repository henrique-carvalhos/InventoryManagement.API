using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteSale
{
    public class DeleteSaleCommand : IRequest<ResultViewModel>
    {
        public DeleteSaleCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
