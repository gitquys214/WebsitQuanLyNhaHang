using Microsoft.AspNetCore.Mvc;
using ASMC5.Services;

namespace ASMC5.Controllers
{
    public class KhachHangController : Controller
    {
        private IKhachHang _khachhang;
        public KhachHangController(IKhachHang khachhang)
        {

            _khachhang = khachhang;
        }
        public IActionResult Index()
        {

            return View(_khachhang.GetAll());
        }
        public IActionResult Details(int id)
        {
            return View(_khachhang.Get(id));
        }
    }
}
