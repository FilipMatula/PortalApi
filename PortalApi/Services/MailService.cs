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
using System.Text;
using PortalApi.Entities;

namespace PortalApi.Services
{
    public class MailService : IMailService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public Dictionary<string, string> Images { get; set; } = new Dictionary<string, string>()
        {
            { "fb", "https://ikhfrc.stripocdn.email/content/assets/img/social-icons/circle-black-bordered/facebook-circle-black-bordered.png"},
            { "insta", "https://ikhfrc.stripocdn.email/content/assets/img/social-icons/circle-black-bordered/instagram-circle-black-bordered.png"},
            { "twitter", "https://ikhfrc.stripocdn.email/content/assets/img/social-icons/circle-black-bordered/twitter-circle-black-bordered.png"},
            { "yt", "https://ikhfrc.stripocdn.email/content/assets/img/social-icons/circle-black-bordered/youtube-circle-black-bordered.png"}
        };

        public MailService(IWebHostEnvironment env, IConfiguration configuration)
        {
            _environment = env ?? throw new ArgumentNullException(nameof(env));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        [ProlongExpirationTime]
        [LogFailure]
        public void SendConfirmationEmail(string email, string activationLink, string userName)
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email));
                message.From = new MailAddress(_configuration["SmtpSettings:Email"], _configuration["SmtpSettings:Title"]);
                message.Subject = "Potwierdź swój adres mail";
                message.Body = CreateEmailConfirmationBody(activationLink, userName);
                message.IsBodyHtml = true;

                SendEmail(message);
            }
        }

        [ProlongExpirationTime]
        [LogFailure]
        public void SendPasswordResetEmail(string email, string password, string userName)
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email));
                message.From = new MailAddress(_configuration["SmtpSettings:Email"], _configuration["SmtpSettings:Title"]);
                message.Subject = "Twoje nowe hasło";
                message.Body = CreatePasswordResetBody(password, userName);
                message.IsBodyHtml = true;

                SendEmail(message);
            }
        }

        public string CreateEmailConfirmationBody(string link, string userName)
        {

            string mailBody = GetMessageBodyFromTemplate("EmailConfirmationTemplate.html").HtmlBody;

            mailBody = mailBody.Replace("{0}", PortalInfo.AppName);
            mailBody = mailBody.Replace("{1}", userName);
            mailBody = mailBody.Replace("{2}", link);
            mailBody = mailBody.Replace("{3}", PortalInfo.FacebookLink);
            mailBody = mailBody.Replace("{4}", PortalInfo.InstagramLink);
            mailBody = mailBody.Replace("{5}", Images["fb"]);
            mailBody = mailBody.Replace("{6}", Images["insta"]);
            mailBody = mailBody.Replace("{7}", PortalInfo.Footer);
            return mailBody;
        }

        public string CreatePasswordResetBody(string password, string userName)
        {
            string mailBody = GetMessageBodyFromTemplate("PasswordResetTemplate.html").HtmlBody;

            mailBody = mailBody.Replace("{0}", PortalInfo.AppName);
            mailBody = mailBody.Replace("{1}", userName);
            mailBody = mailBody.Replace("{2}", password);
            mailBody = mailBody.Replace("{3}", PortalInfo.FacebookLink);
            mailBody = mailBody.Replace("{4}", PortalInfo.InstagramLink);
            mailBody = mailBody.Replace("{5}", Images["fb"]);
            mailBody = mailBody.Replace("{6}", Images["insta"]);
            mailBody = mailBody.Replace("{7}", PortalInfo.Footer);
            return mailBody;
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
