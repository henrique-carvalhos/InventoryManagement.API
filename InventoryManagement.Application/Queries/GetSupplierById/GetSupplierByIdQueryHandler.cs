using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetSupplierById
{
    public class GetSupplierByIdQueryHandler : IRequestHandler<GetSupplierByIdQuery, ResultViewModel<SupplierViewModel>>
    {
        private readonly ISupplierRepository _repository;
        public GetSupplierByIdQueryHandler(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<SupplierViewModel>> Handle(GetSupplierByIdQuery request, CancellationToken cancellationToken)
        {
            var supplier = await _repository.GetbyId(request.Id);

            if(supplier is null)
            {
                return ResultViewModel<SupplierViewModel>.Error("Fornecedor não encontrada");
            }

            var model = SupplierViewModel.FromEntity(supplier);

            return ResultViewModel<SupplierViewModel>.Success(model);
        }
    }
}
