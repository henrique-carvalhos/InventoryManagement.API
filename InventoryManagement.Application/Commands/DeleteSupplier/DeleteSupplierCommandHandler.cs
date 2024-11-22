using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteSupplier
{
    public class DeleteSupplierCommandHandler : IRequestHandler<DeleteSupplierCommand, ResultViewModel>
    {
        private readonly ISupplierRepository _repository;
        public DeleteSupplierCommandHandler(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = await _repository.GetbyId(request.Id);

            if (supplier is null)
            {
                return ResultViewModel.Error("Fornecedor não encontrado");
            }

            supplier.SetAsDeleted();
            await _repository.Update(supplier);

            return ResultViewModel.Success();
        }
    }
}
