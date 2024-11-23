using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteSale
{
    public class DeleteSaleCommandHandler : IRequestHandler<DeleteSaleCommand, ResultViewModel>
    {
        private readonly ISaleRepository _repository;
        public DeleteSaleCommandHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(DeleteSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = await _repository.GetbyId(request.Id);

            if (sale is null)
            {
                return ResultViewModel.Error("Venda não encontrada");
            }

            sale.SetAsDeleted();

            await _repository.Update(sale);

            return ResultViewModel.Success();
        }
    }
}
