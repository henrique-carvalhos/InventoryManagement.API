using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetSaleItemById
{
    public class GetSaleItemByIdQueryHandler : IRequestHandler<GetSaleItemByIdQuery, ResultViewModel<SaleItemViewModel>>
    {
        private readonly ISaleItemRepository _repository;
        public GetSaleItemByIdQueryHandler(ISaleItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<SaleItemViewModel>> Handle(GetSaleItemByIdQuery request, CancellationToken cancellationToken)
        {
            var saleItem = await _repository.GetbyId(request.Id);

            if(saleItem is null)
            {
                return ResultViewModel<SaleItemViewModel>.Error($"Itens da venda {request.Id} não existem");
            }

            var model = SaleItemViewModel.FromEntity(saleItem);

            return ResultViewModel<SaleItemViewModel>.Success(model);
        }
    }
}
