using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteSaleItem
{
    public class DeleteSaleItemCommandHandler : IRequestHandler<DeleteSaleItemCommand, ResultViewModel>
    {
        private readonly ISaleItemRepository _repository;
        public DeleteSaleItemCommandHandler(ISaleItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(DeleteSaleItemCommand request, CancellationToken cancellationToken)
        {
            var saleItem = await _repository.GetbyId(request.Id);

            if(saleItem is null)
            {
                return ResultViewModel.Error($"Itens da venda {request.Id} não existem");
            }

            saleItem.SetAsDeleted();

            await _repository.Update(saleItem);

            return ResultViewModel.Success();
        }
    }
}
