using ASMC5.Models;
using ASMC5.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ASMC5.Services
{
    public interface IKhachHang
    {
        List<KhachHang> GetAll();
        KhachHang Get(int id);
        KhachHang GetByEmail(string email);
        int AddKhachHang(KhachHang KhachHang);
        int UpdateKhachHang(KhachHang KhachHang);
        bool Login(Login login);
        bool isExistEmail(string email);
        bool ChangePass(int id, DoiMatKhau doiMatKhau);
    }
    public class KhachHangSvc:IKhachHang
    {
        private DataContext _context;
        private IMahoaHelper _mahoa;
        private ISendEmail _sendEmail;
        public KhachHangSvc(DataContext context,IMahoaHelper mahoa,ISendEmail sendEmail)
        {
            _mahoa = mahoa;
            _context = context;
            _sendEmail = sendEmail;
        }
        public List<KhachHang> GetAll()
        {
            var list=new List<KhachHang>();
            list = _context.KhachHangs.ToList();
            return list;
        }
        public KhachHang Get(int id)
        {
            var kh=new KhachHang();
            kh = _context.KhachHangs.Where(x => x.Id_KH == id).FirstOrDefault();
            return kh;
        }
        public KhachHang GetByEmail(string email)
        {
            var khachhang = new KhachHang();
            khachhang = _context.KhachHangs.Where(x => x.Email == email).FirstOrDefault();
            return khachhang;
        }
        public bool isExistEmail(string email)
        {
            bool ret = false;
            var user = _context.KhachHangs.Where(x => x.Email == email).FirstOrDefault();
            if (user != null)
            {
                ret = true;
            }
            return ret;
        }
        public bool ChangePass(int id, DoiMatKhau doiMatKhau)
        {
            bool ret = false;
            try
            {
                KhachHang user = null;
                user = _context.KhachHangs.Find(id);
                _sendEmail.SendEmailChangePass(user.Email, doiMatKhau.NewPass, user.Name);
                user.PassWord = _mahoa.Mahoa(doiMatKhau.NewPass);
                _context.KhachHangs.Update(user);
                _context.SaveChanges();
                ret = true;
            }
            catch
            {
                ret = false;
            }
            return ret;
        }
        public int AddKhachHang(KhachHang khachHang)
        {
            int ret = 0;
            try
            {
                _sendEmail.SendEmail(khachHang.Email,khachHang.PassWord,khachHang.Name);
                khachHang.PassWord = _mahoa.Mahoa(khachHang.PassWord);
                _context.KhachHangs.Add(khachHang);
                _context.SaveChanges();
                ret = khachHang.Id_KH;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
         
        public int UpdateKhachHang(KhachHang khachHang)
        {
            int ret = 0;
            try
            {
                _context.KhachHangs.Update(khachHang);
                _context.SaveChanges();
                ret = khachHang.Id_KH;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public bool Login(Login login)
        {
            bool ret = false;
            try
            {
                var pass = _mahoa.Mahoa(login.PassWord);
                var lg=_context.KhachHangs.Where(x=>x.Email==login.Email && x.PassWord==pass).FirstOrDefault();
                if(lg!=null)
                {
                    ret = true;
                }
            }
            catch
            {
                ret = false;
            }
            return ret;
        }
        
    }
}
