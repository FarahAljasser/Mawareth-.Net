using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mawareth.Services
{
    public static class EmailSender
    {
        public static bool Send(string to, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("mawareth2021@gmail.com");
                mail.To.Add(to);
                mail.Subject = "إعادة تعيين اسم المستخدم وكلمة المرور";
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("mawareth2021@gmail.com", "mawareth");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
