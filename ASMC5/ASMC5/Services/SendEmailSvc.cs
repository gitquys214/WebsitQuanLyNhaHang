using System.Net;
using System.Net.Mail;
using System.Text;

namespace ASMC5.Services
{
    public interface ISendEmail
    {
        void SendEmail(string email,string pass,string name);
        void SendEmailChangePass(string email,string pass,string name);
    }
    public class SendEmailSvc : ISendEmail
    {
        public void SendEmail(string email,string pass,string name)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("vincps16904@fpt.edu.vn");
                mail.To.Add(email);
                mail.Subject = "Đăng ký tài khoản thành công";
                mail.Body = "<h5>Xin chào " + name + "</h5>" + "<p>Chào mừng bạn đến với VIX FOOD</p>"+
                    "<p>Đây là mật khẩu đăng nhập trang web nhà hàng của bạn: " + pass + "/p>" +
                    "<p>Chúc bạn một ngày tốt lành</p>" +
                    "<p><i style='color:red'>Lưu ý: đây là mật khẩu đăng nhập vui lòng không chia sẽ cho bất kì ai<i></p>";
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("vincps16904@fpt.edu.vn", "Caovi662529");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
        public void SendEmailChangePass(string email, string pass, string name)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("vincps16904@fpt.edu.vn");
                mail.To.Add(email);
                mail.Subject = "Thay đổi mật khẩu đăng nhập";
                mail.Body = "<h5>Xin chào " + name + "</h5>" + "<p>Tài khoản của bạn vừa thay đổi mật khẩu</p>" +
                    "<p>Đây là mật khẩu mới của bạn: " + pass + "</p>" +
                    "<p><i style='color:red'>Lưu ý: đây là mật khẩu đăng nhập vui lòng không chia sẽ cho bất kì ai<i></p>";
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("vincps16904@fpt.edu.vn", "Caovi662529");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}
