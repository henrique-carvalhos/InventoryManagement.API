using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSupplier
{
    public class InsertSupplierCommandHandler : IRequestHandler<InsertSupplierCommand, ResultViewModel<int>>
    {
        private readonly ISupplierRepository _repository;   
        public InsertSupplierCommandHandler(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = request.ToEntity();

            await _repository.Add(supplier);

            return ResultViewModel<int>.Success(supplier.Id);
        }
    }
}
