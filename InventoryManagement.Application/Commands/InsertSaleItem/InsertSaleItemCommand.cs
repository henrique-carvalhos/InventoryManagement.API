using InventoryManagement.Application.Models;
using InventoryManagement.Core.Entities;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertSaleItem
{
    public class InsertSaleItemCommand : IRequest<ResultViewModel<int>>
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int IdSale { get; set; }
        public int IdProduct { get; set; }

        public SaleItem ToEntity()
            => new(Quantity, UnitPrice, IdSale, IdProduct);
    }
}
