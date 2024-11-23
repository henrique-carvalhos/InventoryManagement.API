namespace InventoryManagement.Core.Entities
{
    public class Sale : BaseEntity
    {
        public Sale(decimal totalAmount, int idCustomer) : base()
        {
            TotalAmount = totalAmount;
            SaleDate = DateTime.Now;

            IdCustomer = idCustomer;

            SaleItems = [];
        }

        public DateTime SaleDate { get; private set; }
        public decimal TotalAmount { get; private set; }

        public int IdCustomer { get; private set; }
        public Customer Customer { get; private set; }

        public List<SaleItem> SaleItems { get; set; }

        public void Update(decimal totalAmount, int idCustomer)
        {
            TotalAmount = totalAmount;
            IdCustomer = idCustomer;
        }
    }
}
