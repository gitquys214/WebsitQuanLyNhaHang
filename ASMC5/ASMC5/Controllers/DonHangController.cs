using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASMC5.Models;
using ASMC5.Services;

namespace ASMC5.Controllers
{
    public class DonHangController : Controller
    {
        private readonly IDonHang _donhang;
        private readonly IDonHangCT _donHangCT;
    
        public DonHangController(IDonHang donhang,IDonHangCT donHangCT)
        {
            _donHangCT = donHangCT;
            _donhang = donhang;
        }

        // GET: DonHangs
        public IActionResult Index()
        {
            return View(_donhang.GetList());
        }
        public IActionResult Details(int id)
        {
            ViewBag.dhct=_donHangCT.GetListCT(id);
            return View(_donhang.GetDonHang(id));
        }
        public IActionResult History(int id)
        {
            return View(_donhang.GetByKH(id));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_donhang.GetDonHang(id));
        }
        [HttpPost]
        public IActionResult Edit(int id,DonHang donHang)
        {
            if(ModelState.IsValid)
            {
                _donhang.EditDonHang(id, donHang);
                return RedirectToAction(nameof(Index));
            }
            return View(donHang);
        }
    }
}
