using Microsoft.AspNetCore.Hosting;
using MimeKit;
using PortalApi.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PortalApi.Services
{
    public class MailService : IMailService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public MailService(IWebHostEnvironment env, IConfiguration configuration)
        {
            _environment = env ?? throw new ArgumentNullException(nameof(env));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        [ProlongExpirationTime]
        [LogFailure]
        public void SendEmailConfirmationEmail(string email, string activationLink)
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email));
                message.From = new MailAddress(_configuration["SmtpSettings:Email"], _configuration["SmtpSettings:Title"]);
                message.Subject = "Confirm email adress";
                message.Body = CreateEmailConfirmationBody(activationLink);
                message.IsBodyHtml = true;

                SendEmail(message);
            }
        }

        [ProlongExpirationTime]
        [LogFailure]
        public void SendPasswordResetEmail(string email, string password)
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email));
                message.From = new MailAddress(_configuration["SmtpSettings:Email"], _configuration["SmtpSettings:Title"]);
                message.Subject = "Your new password";
                message.Body = CreatePasswordResetBody(password);
                message.IsBodyHtml = true;

                SendEmail(message);
            }
        }

        public string CreateEmailConfirmationBody(string link)
        {
            return string.Format(GetMessageBodyFromTemplate("EmailConfirmationTemplate.html").HtmlBody, link);
        }

        public string CreatePasswordResetBody(string password)
        {
            return string.Format(GetMessageBodyFromTemplate("PasswordResetTemplate.html").HtmlBody, password);
        }

        public BodyBuilder GetMessageBodyFromTemplate(string templateFile)
        {
            var pathToFile = _environment.WebRootPath + "\\EmailTemplates\\" + templateFile;
            var builder = new BodyBuilder();
            using (StreamReader SourceReader = File.OpenText(pathToFile))
            {
                builder.HtmlBody = SourceReader.ReadToEnd();
            }
            return builder;
        }

        public void SendEmail(MailMessage message)
        {
            using (var client = new SmtpClient(_configuration["SmtpSettings:SmtpServer"]))
            {
                client.Port = 587;
                client.Credentials = new NetworkCredential(_configuration["SmtpSettings:Email"], _configuration["SmtpSettings:Password"]);
                client.EnableSsl = true;
                client.Send(message);
            }
        }
    }
}
