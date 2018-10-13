using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.BusinessLayer.Concrete.Mail
{
    public static class SendMail
    {
        public static void MailSend(string receiver, string subject, string content)
        {
            #region mailGonderme
            var fromAddress = new MailAddress("infosautoyota@gmail.com", "Parola Değiştir");
            var toAddress = new MailAddress(receiver, "To Name");
            const string fromPassword = "Toyota12*";
            
            
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = content
            })
            {
                smtp.Send(message);
            }

            #endregion
        }
    }
}
