using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetCustomerById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, ResultViewModel<CustomerViewModel>>
    {
        private readonly ICustomerRepository _repository;
        public GetCustomerByIdQueryHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<CustomerViewModel>> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetbyId(request.Id);

            if (customer is null)
            {
                return ResultViewModel<CustomerViewModel>.Error("Cliente não encontrada");
            }

            var model = CustomerViewModel.FromEntity(customer);

            return ResultViewModel<CustomerViewModel>.Success(model);
        }
    }
}
