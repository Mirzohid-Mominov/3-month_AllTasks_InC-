using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender_HT2_N41
{
    public class Sender
    {
        private readonly object _lock = new object();
        private SmtpClient? _smtpClient;
        
        public Sender()
        {
            _smtpClient = new SmtpClient("smtp.gmail.com", 587);
            _smtpClient.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
            _smtpClient.EnableSsl = true;
        }

        public async Task SendEmailAsync(EmailTemplate emailTemplate)
        {
            lock (_lock)
            {
                var fullName = $"{emailTemplate.User.FirstName} {emailTemplate.User.LastName}";
                var mail = new MailMessage(Constants.SenderEmailAddress, emailTemplate.User.EmailAddress);
                mail.Subject = Constants.WelcomeSubject
                    .Replace("{ { User} }", fullName);
                mail.Body = Constants.WelcomeBody;

                _smtpClient.SendMailAsync(mail).Wait();
            }
        }
    }
}
