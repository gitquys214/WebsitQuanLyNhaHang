using Microsoft.AspNetCore.Mvc;
using ASMC5.Models.ViewModels;
using ASMC5.Models;
using ASMC5.Services;
using System.Collections.Generic;

namespace ASMC5.Controllers
{
    public class AccountController : Controller
    {
        private readonly INguoiDung _nguoidung;
        private readonly IKhachHang _khachhang;
        public static NguoiDung User;
        public static KhachHang Customer;
        public AccountController(INguoiDung nguoidung, IKhachHang khachhang)
        {
            _khachhang = khachhang;
            _nguoidung = nguoidung;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                if(login.role==true)
                {
                    if (_nguoidung.Login(login))
                    {
                        SessionSvc.SetobjectAsJson(HttpContext.Session, "user", _nguoidung.GetByEmail(login.Email));
                        User = SessionSvc.GetobjectFromJson<NguoiDung>(HttpContext.Session, "user");
                        return RedirectToAction("Index", "HomePage");
                    }
                    else
                    {
                        TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Tài khoản hoặc mật khẩu không chính xác");
                        return View(login);
                    }
                }  
                else
                {
                    if (_khachhang.Login(login))
                    {
                        SessionSvc.SetobjectAsJson(HttpContext.Session, "khachhang", _khachhang.GetByEmail(login.Email));
                        Customer = SessionSvc.GetobjectFromJson<KhachHang>(HttpContext.Session, "khachhang");

                        return RedirectToAction("Index","HomePage");
                    }
                    else
                    {
                        TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Tài khoản hoặc mật khẩu không chính xác");
                        return View(login);
                    }
                }    
                
            }
            return View(login);
        }

        [HttpGet]
        public IActionResult DangKy()
        {
            return View();
            
        }
        [HttpPost]
        public IActionResult DangKy(KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                if (_khachhang.isExistEmail(khachHang.Email) == false)
                {
                    _khachhang.AddKhachHang(khachHang);
                    TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Đăng ký tài khoản thành công!!!");
                    return RedirectToAction(nameof(Login));
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
        public IActionResult DoiMatKhau()
        {
            var user = SessionSvc.GetobjectFromJson<NguoiDung>(HttpContext.Session, "user");
            var khachhang = SessionSvc.GetobjectFromJson<KhachHang>(HttpContext.Session, "khachhang");
            if (user == null)
            {
                ViewBag.email = khachhang.Email;
                return View();
            }
            else
            {
                ViewBag.email = user.Email;
                return View();

            }
        }
        [HttpPost]
        public IActionResult DoiMatKhau(DoiMatKhau doiMatKhau)
        {
            if(ModelState.IsValid)
            {
                if(_nguoidung.isPass(doiMatKhau.PassWord)==false)
                {
                    _nguoidung.ChangePass(doiMatKhau);
                    return RedirectToAction(nameof(Login));
                }
                else
                {
                    TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Mật khẩu củ không chính xác!!!");
                    return View();
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult CapNhatThongTinKH()
        {
            var customer = SessionSvc.GetobjectFromJson<KhachHang>(HttpContext.Session, "khachhang");
            return View(_khachhang.Get(customer.Id_KH));
        }
        [HttpPost]
        public IActionResult CapNhatThongTinKH(KhachHang khachHang)
        {
            if(ModelState.IsValid)
            {
                _khachhang.UpdateKhachHang(khachHang);
                TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Cập nhật thông tin thành công");
                return RedirectToAction("Index", "HomePage", TempData["alert"]);
            }
            TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Cập nhật thông tin không thành công");
            return View();
        }
        [HttpGet]
        public IActionResult CapNhatThongTinUser()
        {
            var user = SessionSvc.GetobjectFromJson<NguoiDung>(HttpContext.Session, "user");

            return View(_nguoidung.Get(user.Id_NguoiDung));
        }
        [HttpPost]
        public IActionResult CapNhatThongTinUser(NguoiDung nguoiDung)
        {
            if (ModelState.IsValid)
            {
                _nguoidung.UpdateNguoiDung(nguoiDung);
                TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Cập nhật thông tin thành công");
                return RedirectToAction("Index", "HomePage",TempData["alert"]);
            }
            TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Cập nhật thông tin không thành công");
            return View();
        }
        public IActionResult Logout()
        {
            SessionSvc.SetobjectAsJson(HttpContext.Session, "user", "");
            SessionSvc.SetobjectAsJson(HttpContext.Session, "khachhang", "");
            Customer = null;
            User = null;
            return RedirectToAction("Index", "HomePage");
        }    
    }
}
