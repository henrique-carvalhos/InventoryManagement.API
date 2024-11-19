using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, ResultViewModel>
    {
        private readonly ICustomerRepository _repository;
        public UpdateCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetbyId(request.IdCustomer);

            if (customer is null)
            {
                return ResultViewModel.Error("Cliente não existe.");
            }

            customer.Update(request.Name, request.Email, request.Phone);

            await _repository.Update(customer);

            return ResultViewModel.Success();
        }
    }
}
