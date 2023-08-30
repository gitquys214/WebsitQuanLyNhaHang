using Microsoft.EntityFrameworkCore;
using ASMC5.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASMC5.Services
{
    public interface IDonHang
    {
        List<DonHang> GetList();
        List<DonHang> GetByKH(int id_KH);
        DonHang GetDonHang(int id);
        int AddDonHang(DonHang donHang);
        int EditDonHang(int id, DonHang donHang);
        
    }
    public class DonHangSvc:IDonHang
    {
        private DataContext _context;
        public DonHangSvc(DataContext context)
        {
            _context = context;
        }
        public List<DonHang> GetList()
        {
            var list = new List<DonHang>();
            list = _context.DonHangs.OrderByDescending(x => x.NgayDat)
                 .Include(x => x.KhachHang)
                 .Include(x => x.DonHangChiTiet)
                 .ToList();
            return list;
        }
        public List<DonHang> GetByKH(int id_KH)
        {
            var list = new List<DonHang>();
            list = _context.DonHangs.Where(x => x.Id_KhachHang == id_KH).OrderByDescending(x => x.NgayDat)
                 .Include(x => x.KhachHang)
                 .Include(x => x.DonHangChiTiet)
                 .ToList();
            return list;
        }

        public DonHang GetDonHang(int id)
        {
            var dh = new DonHang();
            dh = _context.DonHangs.Where(x => x.Id_DonHang == id)
                 .Include(x => x.KhachHang)
                 .Include(x => x.DonHangChiTiet)
                 .FirstOrDefault();
            return dh;
        }

        public int AddDonHang(DonHang donHang)
        {
            int ret = 0;
            try
            {
                _context.DonHangs.Add(donHang);
                _context.SaveChanges();
                ret = donHang.Id_DonHang;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public int EditDonHang(int id, DonHang donHang)
        {
            int ret = 0;
            try
            {
                _context.DonHangs.Update(donHang);
                _context.SaveChanges();
                ret = donHang.Id_DonHang;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    } 
}
