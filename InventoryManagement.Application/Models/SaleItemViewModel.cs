using InventoryManagement.Core.Entities;

namespace InventoryManagement.Application.Models
{
    public class SaleItemViewModel
    {
        public SaleItemViewModel(int id, int quantity, decimal unitPrice, int idSale, decimal sale, int idProduct, string product, DateTime createdAt, bool isDeleted)
        {
            Id = id;
            Quantity = quantity;
            UnitPrice = unitPrice;
            IdSale = idSale;
            Sale = sale;
            IdProduct = idProduct;
            Product = product;
            CreatedAt = createdAt;
            IsDeleted = isDeleted;
        }

        public int Id { get; set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int IdSale { get; private set; }
        public decimal Sale { get; private set; }
        public int IdProduct { get; private set; }
        public string Product { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsDeleted { get; private set; }

        public static SaleItemViewModel FromEntity(SaleItem saleItem)
        => new(
            saleItem.Id, 
            saleItem.Quantity, 
            saleItem.UnitPrice, 
            saleItem.Sale.Id, 
            saleItem.Sale.TotalAmount, 
            saleItem.Product.Id, 
            saleItem.Product.Name,
            saleItem.CreatedAt,
            saleItem.IsDeleted);
    }
}
