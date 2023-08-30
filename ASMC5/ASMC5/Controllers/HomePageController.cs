using Microsoft.AspNetCore.Mvc;
using ASMC5.Models;
using ASMC5.Services;
using System.Collections.Generic;
using System.Linq;

namespace ASMC5.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IMoan _monan;
        private readonly IDonHang _donHang;
        private readonly IDonHangCT _donHangCT;
        public HomePageController(IMoan monan, IDonHang donhang, IDonHangCT donHangCT)
        {
            _donHang = donhang;
            _donHangCT= donHangCT;
            _monan = monan;
        }
        public IActionResult Index()
        {
            return View(_monan.GetAll());
        }
        public IActionResult SanPham(int id)
        {
            if(id==1)
            {
                ViewBag.Title = "Điểm tâm";
                return View(_monan.GetDiemTam());
            }
            if (id == 2)
            {
                ViewBag.Title = "Nước uống";
                return View(_monan.GetNuoc());
            }
            //if (id == 3)
            //{
            //    ViewBag.Title = "Món chay";
            //    return View(_monan.GetMonChay());
            //}
            return View(_monan.GetAll());
        }
    }
}
