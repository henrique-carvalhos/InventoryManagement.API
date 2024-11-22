using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertProduct
{
    public class InsertProductCommandHandler : IRequestHandler<InsertProductCommand, ResultViewModel<int>>
    {
        private readonly IProductRepository _repository;
        public InsertProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.ToEntity();

            await _repository.Add(product);

            return ResultViewModel<int>.Success(product.Id);
        }
    }
}
