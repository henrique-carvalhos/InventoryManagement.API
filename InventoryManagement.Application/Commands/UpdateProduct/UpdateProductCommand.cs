using InventoryManagement.Application.Models;
using MediatR;

namespace InventoryManagement.Application.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<ResultViewModel>
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public int IdCategory { get; set; }
        public int IdSupplier { get; set; }
    }
}
