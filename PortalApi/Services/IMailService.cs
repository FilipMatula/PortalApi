using System.Net.Mail;

namespace PortalApi.Services
{
    public interface IMailService
    {
        string CreateEmailConfirmationBody(string link, string userName);
        string CreatePasswordResetBody(string password);
        void SendConfirmationEmail(string email, string activationLink, string userName);
        void SendPasswordResetEmail(string email, string password);
        void SendEmail(MailMessage message);
    }
}