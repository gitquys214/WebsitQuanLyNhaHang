using Microsoft.AspNetCore.Mvc;
using ASMC5.Services;
using ASMC5.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASMC5.Controllers
{
    public class CartController : Controller
    {
        private ICart _cart;
        private readonly IDonHang _donHang;
        private readonly IDonHangCT _donHangCT;

        public CartController(ICart cart,IDonHang donhang,IDonHangCT donHangCT)
        {
            _donHang= donhang;
            _donHangCT= donHangCT;
            _cart = cart;
        }
        public IActionResult Index()
        {
            var cus = SessionSvc.GetobjectFromJson<KhachHang>(HttpContext.Session, "khachhang");
            var cart = SessionSvc.GetobjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if(cart == null)
            {
                if(cus==null)
                {
                    ViewBag.countCus = 0;
                }
                else
                {
                    ViewBag.countCus = 1;
                    ViewBag.cus = cus;
                }
                ViewBag.count = 0;
                return View();
            }
            else
            {
                if (cus == null)
                {
                    ViewBag.countCus = 0;
                }
                else
                {
                    ViewBag.countCus = 1;
                    ViewBag.cus = cus;
                }
                ViewBag.cart = cart;
                int ship = 30000;
                ViewBag.thanhtien = cart.Sum(item => item.monAn.Price * item.Qty).ToString("0,000");
                ViewBag.vat = (cart.Sum(item => item.monAn.Price * item.Qty) * 0.1).ToString("0,000");
                double total = cart.Sum(item => item.monAn.Price * item.Qty) + (cart.Sum(item => item.monAn.Price * item.Qty) * 0.1) + 30000;
                ViewBag.tongtien = total.ToString("0,000");
                ViewBag.count = cart.Count();
                return View(cart);
            }
        }
        private int isExist(int id)
        {
            List<Item> cart = SessionSvc.GetobjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].monAn.Id_MonAn.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        public IActionResult Buy(int id)
        {
            if (SessionSvc.GetobjectFromJson<List<MonAn>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item
                {
                    monAn = _cart.Get(id),
                    Qty = 1
                    
                });
                SessionSvc.SetobjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionSvc.
                                 GetobjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Qty++;
                }
                else
                {
                    cart.Add(new Item
                    {
                        monAn = _cart.Get(id),
                        Qty = 1
                    });
                }
                SessionSvc.SetobjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction(nameof(Index));
        }
        //add qty
        public IActionResult add(int id)
        {
            List<Item> cart = SessionSvc.GetobjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            if (index != -1)
            {
                cart[index].Qty++;
            }
            SessionSvc.SetobjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        //sub qty
        public IActionResult Sub(int id)
        {
            List<Item> cart = SessionSvc.GetobjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            if (index != -1)
            {
                if (cart[index].Qty > 1)
                {
                    cart[index].Qty--;
                }
            }
            SessionSvc.SetobjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionSvc.GetobjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionSvc.SetobjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index","HomePage");
        }
        public IActionResult ThanhToan(DonHang donHang)
        {
            var cart = SessionSvc.GetobjectFromJson<List<Item>>(HttpContext.Session, "cart");
            var Cus = SessionSvc.GetobjectFromJson<KhachHang>(HttpContext.Session, "khachhang");
            if(Cus == null)
            {
                return RedirectToAction("Login","Account");
            }
            else
            {
                donHang.Id_KhachHang = 1;
                donHang.ThanhTienChuaThue = cart.Sum(item => item.monAn.Price * item.Qty);
                donHang.ThanhTienCoThue = cart.Sum(item => item.monAn.Price * item.Qty) + cart.Sum(item => item.monAn.Price * item.Qty) * 0.1;
                donHang.TrangThai = TrangThai.MoiDat;
                donHang.GhiChu = "Final";
                if (donHang.Id_KhachHang > 0 && donHang.ThanhTienChuaThue > 0 && donHang.ThanhTienCoThue > 0)
                {
                    int id = _donHang.AddDonHang(donHang);
                    foreach (var item in cart)
                    {
                        DonHangChiTiet dh = new DonHangChiTiet()
                        {
                            Id_DonHang = id,
                            Id_MonAn = item.monAn.Id_MonAn,
                            SoLuong = item.Qty,
                            DonGia = item.monAn.Price,
                            VAT = (item.Qty * item.monAn.Price) * 0.1,
                            ThanhTienChuaThue = item.Qty * item.monAn.Price,
                            ThanhTienCoThue = item.Qty * item.monAn.Price + (item.Qty * item.monAn.Price) * 0.1,
                            GhiChu = donHang.GhiChu
                        };
                        _donHangCT.AddDonHangChiTiet(dh);
                    }
                    SessionSvc.SetobjectAsJson(HttpContext.Session, "cart", "");
                    TempData["alert"] = Alert.ShowAlert(Alerts.Success, "Bạn đã đặt hàng thành công!!. Đơn hàng của bạn sẽ được giao trong 30p nữa. Xin chân thành cảm ơn");
                    return RedirectToAction("Index","HomePage");
                }
            }
             return RedirectToAction(nameof(Index));
        }
    }
}
