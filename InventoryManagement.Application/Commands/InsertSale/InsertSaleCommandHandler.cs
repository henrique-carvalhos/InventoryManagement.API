using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSale
{
    public class InsertSaleCommandHandler : IRequestHandler<InsertSaleCommand, ResultViewModel<int>>
    {
        private readonly ISaleRepository _repository;
        public InsertSaleCommandHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = request.ToEntity();

            await _repository.Add(sale);

            return ResultViewModel<int>.Success(sale.Id);
        }
    }
}
