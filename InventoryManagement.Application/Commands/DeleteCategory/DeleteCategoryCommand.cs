using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteCategory
{
    public class DeleteCategoryCommand : IRequest<ResultViewModel>
    {
        public DeleteCategoryCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
