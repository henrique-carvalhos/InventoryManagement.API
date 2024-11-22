using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ResultViewModel<ProductsViewModel>>
    {
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
