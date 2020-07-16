using System.Net.Mail;

namespace PortalApi.Services
{
    public interface IMailService
    {
        string CreateEmailConfirmationBody(string link, string userName);
        string CreatePasswordResetBody(string password, string userName);
        void SendConfirmationEmail(string email, string activationLink, string userName);
        void SendPasswordResetEmail(string email, string password, string userName);
        void SendEmail(MailMessage message);
    }
}