using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetAllCategory
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, ResultViewModel<List<CategoryViewModel>>>
    {
        private readonly ICategoryRepository _repository;
        public GetAllCategoryQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<List<CategoryViewModel>>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAll(request.Search);

            var model = categories.Select(CategoryViewModel.FromEntity).ToList();

            return ResultViewModel<List<CategoryViewModel>>.Success(model);
        }
    }
}
