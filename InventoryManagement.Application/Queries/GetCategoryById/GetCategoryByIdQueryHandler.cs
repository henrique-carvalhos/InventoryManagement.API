using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Queries.GetCategoryById
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, ResultViewModel<CategoryViewModel>>
    {
        private readonly ICategoryRepository _repository;
        public GetCategoryByIdQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<CategoryViewModel>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetbyId(request.Id);

            if(category is null)
            {
                return ResultViewModel<CategoryViewModel>.Error("Categoria não encontrada");
            }

            var model = CategoryViewModel.FromEntity(category);

            return ResultViewModel<CategoryViewModel>.Success(model);
        }
    }
}
