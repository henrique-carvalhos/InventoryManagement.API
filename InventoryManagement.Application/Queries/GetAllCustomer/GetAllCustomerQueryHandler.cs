using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllCustomer
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, ResultViewModel<List<CustomerViewModel>>>
    {
        private readonly ICustomerRepository _repository;
        public GetAllCustomerQueryHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<List<CustomerViewModel>>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            var customers = await _repository.GetAll(request.Search);

            var model = customers.Select(CustomerViewModel.FromEntity).ToList();

            return ResultViewModel<List<CustomerViewModel>>.Success(model);
        }
    }
}
