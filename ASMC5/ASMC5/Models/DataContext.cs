using Microsoft.EntityFrameworkCore;
using ASMC5.Models.ViewModels;

namespace ASMC5.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }
        public DbSet<ASMC5.Models.ViewModels.Login> Login { get; set; }
        public DbSet<ASMC5.Models.ViewModels.DoiMatKhau> DoiMatKhau { get; set; }
    }
}
