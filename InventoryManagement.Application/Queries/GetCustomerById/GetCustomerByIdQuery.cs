using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetCustomerById
{
    public class GetCustomerByIdQuery : IRequest<ResultViewModel<CustomerViewModel>>
    {
        public GetCustomerByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
