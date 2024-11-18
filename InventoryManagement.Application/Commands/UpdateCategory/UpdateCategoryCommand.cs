using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<ResultViewModel>
    {
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
