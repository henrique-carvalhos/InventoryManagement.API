using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ResultViewModel<ProductsViewModel>>
    {
        private readonly IProductRepository _repository;
        public GetProductByIdQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<ProductsViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetbyId(request.Id);

            if (product is null)
            {
                return ResultViewModel<ProductsViewModel>.Error("Produto não existe");
            }

            var model = ProductsViewModel.FromEntity(product);

            return ResultViewModel<ProductsViewModel>.Success(model); ;
        }
    }
}
