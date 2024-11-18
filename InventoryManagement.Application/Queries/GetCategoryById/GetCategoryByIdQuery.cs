using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetCategoryById
{
    public class GetCategoryByIdQuery : IRequest<ResultViewModel<CategoryViewModel>>
    {
        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
