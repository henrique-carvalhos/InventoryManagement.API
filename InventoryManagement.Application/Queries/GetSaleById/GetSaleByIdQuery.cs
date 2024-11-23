using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetSaleById
{
    public class GetSaleByIdQuery : IRequest<ResultViewModel<SaleViewModel>>
    {
        public GetSaleByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
