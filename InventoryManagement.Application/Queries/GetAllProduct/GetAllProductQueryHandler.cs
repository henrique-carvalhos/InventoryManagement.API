using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, ResultViewModel<List<ProductsViewModel>>>
    {
        private readonly IProductRepository _repository;
        public GetAllProductQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<List<ProductsViewModel>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAll(request.Search);

            var model = products.Select(ProductsViewModel.FromEntity).ToList();

            return ResultViewModel<List<ProductsViewModel>>.Success(model); 
        }
    }
}
