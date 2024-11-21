using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllSupplier
{
    public class GetAllSupplierQuery : IRequest<ResultViewModel<List<SupplierViewModel>>>
    {
        public GetAllSupplierQuery(string search)
        {
            Search = search;
        }

        public string Search { get; set; }
    }
}
