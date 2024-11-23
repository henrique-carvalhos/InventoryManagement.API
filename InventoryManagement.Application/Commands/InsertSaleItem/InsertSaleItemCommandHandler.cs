using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSaleItem
{
    public class InsertSaleItemCommandHandler : IRequestHandler<InsertSaleItemCommand, ResultViewModel<int>>
    {
        private readonly ISaleItemRepository _repository;
        public InsertSaleItemCommandHandler(ISaleItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertSaleItemCommand request, CancellationToken cancellationToken)
        {
            var saleItem = request.ToEntity();

            await _repository.Add(saleItem);

            return ResultViewModel<int>.Success(saleItem.Id);
        }
    }
}
