using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateSale
{
    public class UpdateSaleCommand : IRequest<ResultViewModel>
    {
        public int IdSale { get; set; }
        public decimal TotalAmount { get; set; }
        public int IdCustomer { get; set; }
    }
}
