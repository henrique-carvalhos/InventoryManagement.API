using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetSaleById
{
    public class GetSaleByIdQueryHandler : IRequestHandler<GetSaleByIdQuery, ResultViewModel<SaleViewModel>>
    {
        private readonly ISaleRepository _repository;
        public GetSaleByIdQueryHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<SaleViewModel>> Handle(GetSaleByIdQuery request, CancellationToken cancellationToken)
        {
            var sale = await _repository.GetbyId(request.Id);

            if(sale is null)
            {
                return ResultViewModel<SaleViewModel>.Error("Venda não encontrada");
            }

            var model = SaleViewModel.FromEntity(sale);

            return ResultViewModel<SaleViewModel>.Success(model);
        }
    }
}
