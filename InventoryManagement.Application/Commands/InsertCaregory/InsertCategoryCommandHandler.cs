using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertCaregory
{
    public class InsertCategoryCommandHandler : IRequestHandler<InsertCategoryCommand, ResultViewModel<int>>
    {
        private readonly ICategoryRepository _repository;
        public InsertCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<int>> Handle(InsertCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = request.ToEntity();

            await _repository.Add(category);

            return ResultViewModel<int>.Success(category.Id);
        }
    }
}
