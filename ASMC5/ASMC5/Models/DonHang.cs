using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ASMC5.Models
{
    public enum TrangThai
    {
        [Display(Name ="Mới đặt")]
        MoiDat=1,
        [Display(Name ="Đang giao hàng")]
        DangGiao=2,
        [Display(Name ="Đã giao hàng")]
        DaGiao=3
    }
    public class DonHang
    {
        [Key]
        public int Id_DonHang { get; set; }
        [ForeignKey("KhachHang")]
        public int Id_KhachHang { get; set; }
        [Required(ErrorMessage = "Bạn cần chọn ngày"), Display(Name = "Ngày đặt")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgayDat { get; set; } = DateTime.Now;
        [Required,Range(0,double.MaxValue,ErrorMessage ="Bạn cần nhập giá.")]
        [Display(Name ="Thành tiền chưa thuế")]
        public double ThanhTienChuaThue { get; set; }
        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
        [Display(Name = "Thành tiền có thuế")]
        public double ThanhTienCoThue { get; set; }
        [Display(Name ="Trạng thái")]
        [Range(1, int.MaxValue,ErrorMessage ="Bạn cần chọn trạng thái đơn hàng")]
        public TrangThai TrangThai { get; set; }
        [Display(Name ="Ghi Chú")]
        [StringLength(255)]
        public string GhiChu { get; set; }
        public KhachHang KhachHang { get; set; }
        public ICollection<DonHangChiTiet> DonHangChiTiet { get; set; }
    }
}
