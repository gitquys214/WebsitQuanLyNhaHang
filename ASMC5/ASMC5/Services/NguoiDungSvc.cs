using ASMC5.Models;
using ASMC5.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ASMC5.Services
{
    public interface INguoiDung
    {
        List<NguoiDung> GetAll();
        NguoiDung Get(int id);
        NguoiDung GetByEmail(string email);
        int AddNguoiDung(NguoiDung NguoiDung);
        int UpdateNguoiDung(NguoiDung NguoiDung);
        bool Login(Login login);
        bool isExistEmail(string email);
        bool ChangePass(DoiMatKhau doiMatKhau);
        bool isAdmin(string name);
        bool isPass(string pass);
    }
    public class NguoiDungSvc:INguoiDung
    {
        private DataContext _context;
        private IMahoaHelper _mahoa;
        private ISendEmail _sendEmail;
        public NguoiDungSvc(DataContext context,IMahoaHelper mahoa,ISendEmail sendEmail)
        {
            _sendEmail = sendEmail;
            _mahoa= mahoa;
            _context = context;
        }
        public List<NguoiDung> GetAll()
        {
            var list=new List<NguoiDung>();
            list = _context.NguoiDungs.ToList();
            return list;
        }
        public NguoiDung Get(int id)
        {
            var nguoiDung=new NguoiDung();
            nguoiDung = _context.NguoiDungs.Where(x => x.Id_NguoiDung == id).FirstOrDefault();
            return nguoiDung;
        }
        public NguoiDung GetByEmail(string email)
        {
            var nguoiDung = new NguoiDung();
            nguoiDung = _context.NguoiDungs.Where(x => x.Email == email).FirstOrDefault();
            return nguoiDung;
        }
        public bool isExistEmail(string email)
        {
            bool ret = false;
            var user=_context.NguoiDungs.Where(x=>x.Email==email).FirstOrDefault();
            if(user!=null)
            {
                ret = true;
            }
            return ret;
        }
        public bool isAdmin(string name)
        {
            bool ret = false;
            if (name=="Admin" || name=="admin")
            {
                ret = true;
            }
            return ret;
        }
        public bool isPass(string pass)
        {
            bool ret = false;
            string pas=_mahoa.Mahoa(pass);
            var user = _context.NguoiDungs.Where(x => x.PassWord == pas).FirstOrDefault();
            if (user != null)
            {
                ret = true;
            }
            return ret;
        }
        public int AddNguoiDung(NguoiDung nguoiDung)
        {
            int ret = 0;
            try
            {
                _sendEmail.SendEmail(nguoiDung.Email, nguoiDung.PassWord, nguoiDung.Name);
                nguoiDung.PassWord = _mahoa.Mahoa(nguoiDung.PassWord);
                _context.NguoiDungs.Add(nguoiDung);
                _context.SaveChanges();
                ret = nguoiDung.Id_NguoiDung;
            }    
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int UpdateNguoiDung(NguoiDung nguoiDung)
        {
            int ret = 0;
            try
            {    
                _context.NguoiDungs.Update(nguoiDung);
                _context.SaveChanges();
                ret = nguoiDung.Id_NguoiDung;
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
            var pass = _mahoa.Mahoa(login.PassWord);
            var user=_context.NguoiDungs.Where(x=>x.PassWord == pass && x.Email == login.Email && x.Status == Statuss.HoatDong).
                FirstOrDefault();
            if(user!=null)
            {
                ret = true;
            }
            return ret;
        }
        public bool ChangePass(DoiMatKhau doiMatKhau)
        {
            bool ret = false;
            try
            {
                NguoiDung user = null;
                user = _context.NguoiDungs.Where(x=>x.Email==doiMatKhau.Email).FirstOrDefault();
                _sendEmail.SendEmailChangePass(user.Email, doiMatKhau.NewPass, user.Name);
                user.PassWord = _mahoa.Mahoa(doiMatKhau.NewPass);
                _context.NguoiDungs.Update(user);
                _context.SaveChanges();
                ret=true;
            }
            catch
            {
                ret = false;
            }
            return ret;
        }
    }
}
