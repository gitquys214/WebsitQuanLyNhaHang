using Microsoft.AspNetCore.Mvc;
using ASMC5.Services;
using ASMC5.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using Microsoft.AspNetCore.Http;

namespace ASMC5.Controllers
{
    public class MonAnController : Controller
    {
        private IMoan _MonAnSvc;
        private readonly IWebHostEnvironment _hostEnvironment;
        public MonAnController(IMoan MonAnSvc, IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment=hostEnvironment;
            _MonAnSvc = MonAnSvc;
        }
        public IActionResult Index()
        {
            return View(_MonAnSvc.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MonAn monAn)
        {
            string image;
            if (monAn.ImageFile == null)
            {
                image = "AnhMacDinh.jpg";
            }
            else
            {
                image = UpLoadSvc.UploadFile(monAn.ImageFile, _hostEnvironment);
            }
            monAn.Image = image;
            if(ModelState.IsValid)
            {
                _MonAnSvc.AddMonAn(monAn);
                return RedirectToAction(nameof(Index));
            }
            return View();  
        }
        public IActionResult Delete(int id)
        {
            _MonAnSvc.DeleteMonAn(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            return View(_MonAnSvc.Get(id));
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_MonAnSvc.Get(id));
        }
        [HttpPost]
        public IActionResult Update(int id,MonAn monAn)
        {
            string image;
            if(monAn.ImageFile==null)
            {
                image = monAn.Image;
            }    
            else
            {
                image=UpLoadSvc.UploadFile(monAn.ImageFile, _hostEnvironment);
            }
            monAn.Image=image;
            if(ModelState.IsValid)
            {
                _MonAnSvc.UpdateMonAn(id, monAn);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
