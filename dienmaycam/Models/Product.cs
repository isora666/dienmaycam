namespace dienmaycam.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public double SalePrice { get; set; }
        public Guid BrandID { get; set; }

        //quan hệ
        public virtual List<BillDetail>? Billdetail { get; set; }

        public virtual List<CartDetail>? Cartdetail { get; set; }
    }
}