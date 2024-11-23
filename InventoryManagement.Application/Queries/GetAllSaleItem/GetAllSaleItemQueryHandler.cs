using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllSaleItem
{
    public class GetAllSaleItemQueryHandler : IRequestHandler<GetAllSaleItemQuery, ResultViewModel<List<SaleItemViewModel>>>
    {
        private readonly ISaleItemRepository _repository;
        public GetAllSaleItemQueryHandler(ISaleItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<List<SaleItemViewModel>>> Handle(GetAllSaleItemQuery request, CancellationToken cancellationToken)
        {
            var salesItems = await _repository.GetAll(request.Search);

            var model = salesItems.Select(SaleItemViewModel.FromEntity).ToList();

            return ResultViewModel<List<SaleItemViewModel>>.Success(model);
        }
    }
}
