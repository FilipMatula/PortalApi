using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PortalApi.Services
{
    public class MailService : IMailService
    {
        public string CreateEmailConfirmationBody(string link)
        {
            return $"<a href='{link}'>Click</a>";
        }

        public string CreatePasswordResetBody(string password)
        {
            return $"Your new password is: {password}";
        }

        public void SendEmailConfirmationEmail(string email, string activationLink)
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email));
                message.From = new MailAddress("portalrzeszow@gmail.com", "Portal Rzeszow");
                message.Subject = "Confirm email adress";
                message.Body = CreateEmailConfirmationBody(activationLink);
                message.IsBodyHtml = true;

                SendEmail(message);
            }
        }

        public void SendPasswordResetEmail(string email, string password)
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email));
                message.From = new MailAddress("portalrzeszow@gmail.com", "Portal Rzeszow");
                message.Subject = "Your new password";
                message.Body = CreatePasswordResetBody(password);
                message.IsBodyHtml = true;

                SendEmail(message);
            }
        }

        public void SendEmail(MailMessage message)
        {
            using (var client = new SmtpClient("smtp.gmail.com"))
            {
                client.Port = 587;
                client.Credentials = new NetworkCredential("portalrzeszow@gmail.com", "Filip123");
                client.EnableSsl = true;
                client.Send(message);
            }
        }
    }
}
