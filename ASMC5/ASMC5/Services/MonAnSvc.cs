using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using ASMC5.Models;

namespace ASMC5.Services
{
    public interface IMoan
    {
        List<MonAn> GetAll();
        MonAn Get(int id);
        int AddMonAn(MonAn monan);
        void DeleteMonAn(int id);
        int UpdateMonAn(int id,MonAn monan);
        List<MonAn> GetDiemTam();
        List<MonAn> GetNuoc();
        //List<MonAn> GetMonChay();

    }
    public class MonAnSvc:IMoan
    {
        private DataContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public MonAnSvc(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
            _context = context;
        }
        public List<MonAn> GetAll()
        {
            List<MonAn> list=new List<MonAn>();
            list = _context.MonAns.ToList();
            return list;
        }
        public MonAn Get(int id)
        {
            MonAn monAn = new MonAn();
            monAn= _context.MonAns.Where(p=>p.Id_MonAn==id).FirstOrDefault();
            return monAn;
        }
        public int AddMonAn(MonAn monAn)
        {
            int ret = 0;
            try
            {
                _context.MonAns.Add(monAn);
                _context.SaveChanges();
                ret = monAn.Id_MonAn;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public int UpdateMonAn(int id,MonAn monAn)
        {
            int ret = 0;
            try
            {
                _context.MonAns.Update(monAn);
                _context.SaveChanges();
                ret=monAn.Id_MonAn;
            }
            catch
            {
                ret=0;
            }
            return ret;
        }
        public void DeleteMonAn(int id)
        {
            _context.MonAns.Remove(Get(id));
            _context.SaveChanges();
        }
        public List<MonAn> GetDiemTam()
        {
            List<MonAn> list = new List<MonAn>();
            list = _context.MonAns.Where(x => x.PhanLoai.Equals(PhanLoai.DiemTam)).ToList();
            return list;
        }
        public List<MonAn> GetNuoc()
        {
            List<MonAn> list = new List<MonAn>();
            list = _context.MonAns.Where(x => x.PhanLoai.Equals(PhanLoai.Nuoc)).ToList();
            return list;
        }    
        //public List<MonAn> GetMonChay()
        //{
        //    List<MonAn> list = new List<MonAn>();
        //    list = _context.MonAns.Where(x => x.PhanLoai.Equals(PhanLoai.MonChay)).ToList();
        //    return list;
        //}
    }
}
