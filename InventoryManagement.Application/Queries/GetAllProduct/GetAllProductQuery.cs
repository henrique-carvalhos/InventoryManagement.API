using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllProduct
{
    public class GetAllProductQuery : IRequest<ResultViewModel<List<ProductsViewModel>>>
    {
        public GetAllProductQuery(string search)
        {
            Search = search;
        }

        public string Search { get; set; }
    }
}
