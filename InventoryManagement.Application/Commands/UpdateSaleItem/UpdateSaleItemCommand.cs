using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateSaleItem
{
    public class UpdateSaleItemCommand : IRequest<ResultViewModel>
    {
        public int IdSaleItem { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int IdSale { get; set; }
        public int IdProduct { get; set; }
    }
}
