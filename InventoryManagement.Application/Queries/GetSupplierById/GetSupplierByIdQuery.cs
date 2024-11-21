using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetSupplierById
{
    public class GetSupplierByIdQuery : IRequest<ResultViewModel<SupplierViewModel>>
    {
        public GetSupplierByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
