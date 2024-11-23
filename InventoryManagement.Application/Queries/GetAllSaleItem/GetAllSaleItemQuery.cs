using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllSaleItem
{
    public class GetAllSaleItemQuery : IRequest<ResultViewModel<List<SaleItemViewModel>>>
    {
        public GetAllSaleItemQuery(string search)
        {
            Search = search;
        }

        public string Search { get; set; }
    }
}
