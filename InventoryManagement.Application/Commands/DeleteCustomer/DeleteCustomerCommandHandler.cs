using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, ResultViewModel>
    {
        private readonly ICustomerRepository _repository;
        public DeleteCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetbyId(request.Id);

            if (customer is null)
            {
                return ResultViewModel.Error("Fornecedor não encontrado");
            }

            customer.SetAsDeleted();
            await _repository.Update(customer); 

            return ResultViewModel.Success();   
        }
    }
}
