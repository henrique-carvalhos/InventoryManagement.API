using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllSupplier
{
    public class GetAllSupplierQueryHandler : IRequestHandler<GetAllSupplierQuery, ResultViewModel<List<SupplierViewModel>>>
    {
        private readonly ISupplierRepository _repository;
        public GetAllSupplierQueryHandler(ISupplierRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<List<SupplierViewModel>>> Handle(GetAllSupplierQuery request, CancellationToken cancellationToken)
        {
            var supplier = await _repository.GetAll(request.Search);

            var model = supplier.Select(SupplierViewModel.FromEntity).ToList();

            return ResultViewModel<List<SupplierViewModel>>.Success(model);
        }
    }
}
