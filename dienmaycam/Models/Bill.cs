using System.Security.Principal;

namespace dienmaycam.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public string UserID { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatDate { get; set; }
        public virtual List<BillDetail> BillDetail { get; set; }
        public virtual User User { get; set; }
    }
}