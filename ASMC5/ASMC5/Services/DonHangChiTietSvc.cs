using Microsoft.EntityFrameworkCore;
using ASMC5.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASMC5.Services
{
    public interface IDonHangCT
    {
        int AddDonHangChiTiet(DonHangChiTiet donHangChiTiet);
        List<DonHangChiTiet> GetListCT(int id);
    }
    public class DonHangChiTietSvc:IDonHangCT
    {
        private DataContext _context;
        public DonHangChiTietSvc(DataContext context)
        {
            _context = context;
        }
        public List<DonHangChiTiet> GetListCT(int id)
        {
            var list = new List<DonHangChiTiet>();
            list = _context.DonHangChiTiets.Where(x=>x.Id_DonHang==id)
                 .OrderByDescending(x => x.Id_DHCT)
                 .Include(x => x.MonAn)
                 .Include(x => x.DonHang)
                 .ToList();
            return list;
        }
        public int AddDonHangChiTiet(DonHangChiTiet donHangChiTiet)
        {
            int ret = 0;
            try
            {
                _context.DonHangChiTiets.Add(donHangChiTiet);
                _context.SaveChanges();
                ret = donHangChiTiet.Id_DonHang;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }
}
