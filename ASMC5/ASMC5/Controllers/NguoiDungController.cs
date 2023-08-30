using Microsoft.AspNetCore.Mvc;
using ASMC5.Services;
using ASMC5.Models;

namespace ASMC5.Controllers
{
    [Route("[controller]/[action]")]
    public class NguoiDungController : Controller
    {
        private INguoiDung _nguoiDung;
        public NguoiDungController(INguoiDung nguoiDung)
        {
            _nguoiDung = nguoiDung;
        }
        public IActionResult Index()
        {
            return View(_nguoiDung.GetAll());
        }
        public IActionResult Details(int id)
        {
            return View(_nguoiDung.Get(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(NguoiDung nguoiDung)
        {
            if (ModelState.IsValid)
            {
                if(_nguoiDung.isExistEmail(nguoiDung.Email)==false)
                {
                    _nguoiDung.AddNguoiDung(nguoiDung);
                    return RedirectToAction("Index");
                }    
                else
                {
                    TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Email đã tồn tại!!!");
                    return View();
                }    
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_nguoiDung.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(NguoiDung nguoiDung)
        {
            if(nguoiDung.PhoneNo!=null && nguoiDung.Name==null)
            {
                _nguoiDung.UpdateNguoiDung(nguoiDung);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
