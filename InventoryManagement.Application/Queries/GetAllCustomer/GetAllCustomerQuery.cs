using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllCustomer
{
    public class GetAllCustomerQuery : IRequest<ResultViewModel<List<CustomerViewModel>>>
    {
        public GetAllCustomerQuery(string search)
        {
            Search = search;
        }

        public string Search { get; set; }
    }
}
