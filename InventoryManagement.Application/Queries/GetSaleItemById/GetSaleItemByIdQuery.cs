using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetSaleItemById
{
    public class GetSaleItemByIdQuery : IRequest<ResultViewModel<SaleItemViewModel>>
    {
        public GetSaleItemByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
