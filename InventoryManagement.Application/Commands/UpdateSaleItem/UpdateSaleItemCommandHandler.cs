using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateSaleItem
{
    public class UpdateSaleItemCommandHandler : IRequestHandler<UpdateSaleItemCommand, ResultViewModel>
    {
        private readonly ISaleItemRepository _repository;
        public UpdateSaleItemCommandHandler(ISaleItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateSaleItemCommand request, CancellationToken cancellationToken)
        {
            var saleItem = await _repository.GetbyId(request.IdSaleItem);

            if (saleItem is null)
            {
                return ResultViewModel.Error($"Itens da venda {request.IdSaleItem} não existem");
            }

            saleItem.Update(request.Quantity, request.UnitPrice, request.IdSale, request.IdProduct);

            await _repository.Update(saleItem);

            return ResultViewModel.Success();
        }
    }
}
