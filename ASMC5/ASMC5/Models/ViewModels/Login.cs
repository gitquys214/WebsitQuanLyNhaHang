using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASMC5.Models.ViewModels
{
    public class Login
    {
        [Key]
        [Required(ErrorMessage ="Bạn cần nhập email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(12)]
        [MinLength(6,ErrorMessage ="Mật khẩu từ 6 - 12 kí tự")]
        [Required(ErrorMessage = "Bạn cần nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [Required(ErrorMessage ="Bạn cần chọn loại tài khoản")]
        public bool role { get; set; }
    }
}
