using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, ResultViewModel>
    {
        private readonly ICategoryRepository _repository;
        public UpdateCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetbyId(request.IdCategory);

            if (category is null)
            {
                return ResultViewModel.Error("Categoria não existe.");
            }

            category.Update(request.Name, request.Description);

            await _repository.Update(category);

            return ResultViewModel.Success();
        }
    }
}
