namespace dienmaycam.Models
{
    public class BillDetail
    {
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductId { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}