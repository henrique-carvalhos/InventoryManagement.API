using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ResultViewModel>
    {
        private readonly IProductRepository _repository;
        public UpdateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetbyId(request.IdProduct);

            if(product is null)
            {
                return ResultViewModel.Error("Produto não existe");
            }

            product.Update(request.Name, request.Description, request.Price, request.QuantityInStock, request.IdCategory, request.IdSupplier);

            await _repository.Update(product);

            return ResultViewModel.Success();
        }
    }
}
