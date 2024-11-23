using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateSale
{
    public class UpdateSaleCommandHandler : IRequestHandler<UpdateSaleCommand, ResultViewModel>
    {
        private readonly ISaleRepository _repository;
        public UpdateSaleCommandHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = await _repository.GetbyId(request.IdSale);

            if(sale is null)
            {
                return ResultViewModel.Error("Venda não encontrada");
            }

            sale.Update(request.TotalAmount, request.IdCustomer);

            await _repository.Update(sale);

            return ResultViewModel.Success();
        }
    }
}
