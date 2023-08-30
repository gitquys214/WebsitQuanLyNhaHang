using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASMC5.Models
{
    public enum Status
    {
        [Display(Name ="Còn phục vụ")]
        Con=1,
        [Display(Name = "Ngưng phục vụ")]
        Ngung=2
    }
    public enum PhanLoai
    {
        [Display(Name = "Món Ăn")]
        DiemTam=1,
        [Display(Name ="Nước uống")]
        Nuoc=2,
        //[Display(Name ="Tráng Miệng")]
        //MonChay=3
    }
    public class MonAn
    {
        [Key]
        public int Id_MonAn { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tên món ăn")]
        [StringLength(100),MinLength(6,ErrorMessage ="Tên món ăn từ 6-100 kí tự")]
        [Display(Name ="Tên món ăn")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đơn giá")]
        [Display(Name = "Đơn giá")]
        public double Price { get; set; }
        [StringLength(100)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [StringLength (255)]
        [Display(Name ="Hình ảnh")]
        public string Image { get; set; }
        [NotMapped]
        [Display(Name ="Chọn hình")]
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage ="Vui lòng chọn trạng thái hoạt động")]
        public Status Status { get; set; }
        [Required(ErrorMessage ="Vui lòng chọn phân loại món ăn")]
    
        public PhanLoai PhanLoai { get; set; }
        public ICollection<DonHangChiTiet> DonHangChiTiet { get; set; }
    }
}
