using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllSale
{
    public class GetAllSaleQuery : IRequest<ResultViewModel<List<SaleViewModel>>>
    {
        public GetAllSaleQuery(string search)
        {
            Search = search;
        }

        public string Search { get; set; }
    }
}
