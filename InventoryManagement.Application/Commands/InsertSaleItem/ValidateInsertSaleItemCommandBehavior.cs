using InventoryManagement.Application.Models;
using InventoryManagement.Infrastructure.Persistence;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSaleItem
{
    public class ValidateInsertSaleItemCommandBehavior
        : IPipelineBehavior<InsertSaleItemCommand, ResultViewModel<int>>
    {
        private readonly InventoryManagementDbContext _context;
        public ValidateInsertSaleItemCommandBehavior(InventoryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<ResultViewModel<int>> Handle(InsertSaleItemCommand request, RequestHandlerDelegate<ResultViewModel<int>> next, CancellationToken cancellationToken)
        {
            var productExists = _context.Products.Any(p => p.Id == request.IdProduct);

            var saleExists = _context.Sales.Any(s => s.Id == request.IdSale);

            if(!productExists || !saleExists)
            {
                return ResultViewModel<int>.Error("Produto ou venda são inválidos");
            }

            return await next();
        }
    }
}
