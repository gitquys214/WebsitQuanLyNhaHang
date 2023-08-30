using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASMC5.Models
{
    public class DonHangChiTiet
    {
        [Key]
        public int Id_DHCT { get; set; }
        [ForeignKey("DonHang")]
        public int Id_DonHang { get; set; }
        [ForeignKey("MonAn")]
        public int Id_MonAn { get; set; }
        [Required,Display(Name ="Số lượng")]
        [Range(0,int.MaxValue,ErrorMessage ="Số lượng món ăn không hợp lệ")]
        public int SoLuong { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập đơn giá sản phẩm")]
        [Display(Name ="Đơn giá")]
        public double DonGia { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập thuế sản phẩm")]
        [Display (Name ="Thuế VAT")]
        public double VAT { get; set; }
        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
        [Display(Name = "Thành tiền chưa thuế")]
        public double ThanhTienChuaThue { get; set; }
        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
        [Display(Name = "Thành tiền có thuế")]
        public double ThanhTienCoThue { get; set; }
        [StringLength(255),Display(Name ="Ghi Chú")]
        public string GhiChu { get; set; }
        public DonHang DonHang { get; set; }    
        public MonAn MonAn { get; set; }
    }
}
