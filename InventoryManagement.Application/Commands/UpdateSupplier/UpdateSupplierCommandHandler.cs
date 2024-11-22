using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateSupplier
{
    public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierCommand, ResultViewModel>
    {
        private readonly ISupplierRepository _repository;
        public UpdateSupplierCommandHandler(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = await _repository.GetbyId(request.IdSupplier);

            if (supplier is null)
            {
                return ResultViewModel.Error("Fornecedor não existe.");
            }

            supplier.Update(request.Name, request.Contact, request.Email, request.Address);

            await _repository.Update(supplier);

            return ResultViewModel.Success();
        }
    }
}
