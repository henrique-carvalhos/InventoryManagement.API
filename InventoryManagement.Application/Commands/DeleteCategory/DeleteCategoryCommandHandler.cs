using InventoryManagement.Application.Models;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, ResultViewModel>
    {
        private readonly ICategoryRepository _repository;
        public DeleteCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetbyId(request.Id);

            if (category is null)
            {
                return ResultViewModel.Error("Categoria não existe.");
            }

            category.SetAsDeleted();
            await _repository.Update(category);

            return ResultViewModel.Success();
        }
    }
}
