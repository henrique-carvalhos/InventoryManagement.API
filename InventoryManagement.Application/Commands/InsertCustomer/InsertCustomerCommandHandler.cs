using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertCustomer
{
    public class InsertCustomerCommandHandler : IRequestHandler<InsertCustomerCommand, ResultViewModel<int>>
    {
        private readonly ICustomerRepository _repository;
        public InsertCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = request.ToEntity();

            await _repository.Add(customer);

            return ResultViewModel<int>.Success(customer.Id);
        }
    }
}
