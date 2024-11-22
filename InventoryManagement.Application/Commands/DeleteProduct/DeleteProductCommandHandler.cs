using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, ResultViewModel>
    {
        private readonly IProductRepository _repository;
        public DeleteProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var produtc = await _repository.GetbyId(request.Id);

            if(produtc is null)
            {
                return ResultViewModel.Error("Produto não existe");
            }

            produtc.SetAsDeleted();
            await _repository.Update(produtc);

            return ResultViewModel.Success();
        }
    }
}
