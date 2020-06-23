using System.Net.Mail;

namespace PortalApi.Services
{
    public interface IMailService
    {
        string CreateEmailConfirmationBody(string link);
        string CreatePasswordResetBody(string password);
        void SendEmailConfirmationEmail(string email, string activationLink);
        void SendPasswordResetEmail(string email, string password);
        void SendEmail(MailMessage message);
    }
}