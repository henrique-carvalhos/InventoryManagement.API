namespace InventoryManagement.Core.Entities
{
    public class SaleItem : BaseEntity
    {
        public SaleItem(int quantity, decimal unitPrice,int idSale, int idProduct) : base()
        {
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

        public int IdSale { get; private set; }
        public Sale Sale { get; private set; }

        public int IdProduct { get; private set; }
        public Product Product { get; private set; }
    }
}
