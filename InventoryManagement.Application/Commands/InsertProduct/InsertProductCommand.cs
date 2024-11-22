using InventoryManagement.Application.Models;
using InventoryManagement.Core.Entities;
using MediatR;

namespace InventoryManagement.Application.Commands.InsertProduct
{
    public class InsertProductCommand : IRequest<ResultViewModel<int>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public int IdCategory { get; set; }
        public int IdSupplier { get; set; }

        public Product ToEntity()
            => new(Name,  Description, Price, QuantityInStock, IdCategory, IdSupplier);
    }
}
