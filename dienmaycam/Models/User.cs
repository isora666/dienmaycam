using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace dienmaycam.Models
{
    public class User
    {
        [Required]
        [StringLength(450, MinimumLength = 6, ErrorMessage = "Độ dài Username Phải từ 6 - 24")]
        public string UserName { get; set; }

        [Required]
        [StringLength(450, MinimumLength = 6, ErrorMessage = "Độ dài Username Phải từ 6 - 24")]
        public string Password { get; set; }

        public int Role { get; set; }

        //[RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]\\d{3}[\\s.-]\\d{4}$",
        //    ErrorMessage = "Số điện thoại phải đúng format và có 10 chữ số")]
        //public string PhoneNumber { get; set; }
        //[DisplayName("Địa chỉ")]
        //public string Address { get; set; }
        //Quan hệ giữa acc và các thằng khác
        public virtual List<Bill> Bill { get; set; }

        public virtual Cart Cart { get; set; }
    }
}