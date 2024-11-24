using InventoryManagement.Application.Models;
using InventoryManagement.Infrastructure.Persistence;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertProduct
{
    public class ValidateInsertProductCommandBehavior :
        IPipelineBehavior<InsertProductCommand, ResultViewModel<int>>
    {
        private readonly InventoryManagementDbContext _context;
        public ValidateInsertProductCommandBehavior(InventoryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<ResultViewModel<int>> Handle(InsertProductCommand request, RequestHandlerDelegate<ResultViewModel<int>> next, CancellationToken cancellationToken)
        {
            var categoryExists = _context.Categories.Any(c => c.Id == request.IdCategory);

            var supplierExists = _context.Suppliers.Any(s => s.Id == request.IdSupplier);

            if(!categoryExists || !supplierExists)
            {
                return ResultViewModel<int>.Error("Categoria ou fornecedor são inválidos");
            }

            return await next();
        }
    }
}
