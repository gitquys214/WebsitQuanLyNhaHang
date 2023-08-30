using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASMC5.Models
{
    public enum Role
    {
        [Display(Name = "Quản lý")]
        QuanLy = 1,
        [Display(Name = "Nhân viên")]
        NhanVien = 2
    }
    public enum Statuss
    {
        [Display(Name = "Khóa")]
        Khoa = 1,
        [Display(Name = "Đang hoạt động")]
        HoatDong = 2
    }
    public class NguoiDung
    {
        [Key]
        public int Id_NguoiDung { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập email."), DataType(DataType.EmailAddress)]
        [StringLength(30)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập họ và tên")]
        [Display(Name = "Họ và Tên")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ.")]
        [StringLength(255), Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Column(TypeName = "Char(15)"), Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Bạn cần nhập số điện thoại của mình.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn giới tính")]
        [Display(Name = "Giới tính")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Ngày sinh")]
        public DateTime BirthDay { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn chức vụ")]
        [Display(Name = "Chức vụ")]
        public Role Role { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn trạng thái hoạt động")]
        [Display(Name = "Trạng thái")]
        public Statuss Status { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [Column(TypeName = "varchar(50)"), MinLength(6, ErrorMessage = "Mật khẩu từ 6-12 kí tự")]
        [Display(Name ="Mật khẩu")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập lại mật khẩu.")]
        [Column(TypeName = "varchar(50)"), MinLength(6, ErrorMessage = "Mật khẩu từ 6-12 kí tự")]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage = "Mật khẩu không trùng khớp!!!")]
        [NotMapped]
        [Display(Name = "Xác nhận mật khẩu")]
        public string RetypePassWord { get; set; }
    }
}
