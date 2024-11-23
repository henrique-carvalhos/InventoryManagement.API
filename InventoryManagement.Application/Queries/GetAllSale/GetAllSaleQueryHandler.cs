using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllSale
{
    public class GetAllSaleQueryHandler : IRequestHandler<GetAllSaleQuery, ResultViewModel<List<SaleViewModel>>>
    {
        private readonly ISaleRepository _repository;
        public GetAllSaleQueryHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<List<SaleViewModel>>> Handle(GetAllSaleQuery request, CancellationToken cancellationToken)
        {
            var sales = await _repository.GetAll(request.Search);

            var model = sales.Select(SaleViewModel.FromEntity).ToList();

            return ResultViewModel<List<SaleViewModel>>.Success(model);
        }
    }
}
