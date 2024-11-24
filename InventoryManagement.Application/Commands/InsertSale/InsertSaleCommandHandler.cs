using InventoryManagement.Application.Models;
using InventoryManagement.Application.Notification.SaleCreated;
using InventoryManagement.Core.Repositories;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSale
{
    public class InsertSaleCommandHandler : IRequestHandler<InsertSaleCommand, ResultViewModel<int>>
    {
        private readonly ISaleRepository _repository;
        private readonly IMediator _mediator;
        public InsertSaleCommandHandler(ISaleRepository repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<ResultViewModel<int>> Handle(InsertSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = request.ToEntity();

            await _repository.Add(sale);

            var saleCreated = new SaleCreatedNotification(sale.Id, sale.TotalAmount, sale.IdCustomer);

            await _mediator.Publish(saleCreated);

            return ResultViewModel<int>.Success(sale.Id);
        }
    }
}
