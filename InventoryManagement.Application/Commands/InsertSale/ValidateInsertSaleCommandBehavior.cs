using InventoryManagement.Application.Models;
using InventoryManagement.Infrastructure.Persistence;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSale
{
    public class ValidateInsertSaleCommandBehavior
        : IPipelineBehavior<InsertSaleCommand, ResultViewModel<int>>
    {
        private readonly InventoryManagementDbContext _context;
        public ValidateInsertSaleCommandBehavior(InventoryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<ResultViewModel<int>> Handle(InsertSaleCommand request, RequestHandlerDelegate<ResultViewModel<int>> next, CancellationToken cancellationToken)
        {
            var customerExists = _context.Customers.Any(c => c.Id == request.IdCustomer);

            if (!customerExists)
            {
                return ResultViewModel<int>.Error("Cliente inválido");
            }

            return await next();
        }
    }
}
