using InventoryManagement.Application.Models;
using InventoryManagement.Core.Entities;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSale
{
    public class InsertSaleCommand : IRequest<ResultViewModel<int>>
    {
        public decimal TotalAmount { get; set; }
        public int IdCustomer { get; set; }

        public Sale ToEntity()
            => new(TotalAmount, IdCustomer);
    }
}
