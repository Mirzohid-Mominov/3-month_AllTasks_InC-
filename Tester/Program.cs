

using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

//Description
//Implement an EmailService that allows to send, manage emails
//Requirements
//should allow sending emails with just email category
//Deliverables
//Implement an EmailService that composition service include EmailTemplateService, EmailMessageService, and EmailSenderService

public class Program
{
    public class EmailService
    {
        private readonly IEmailMessageService _emailMessageService;
        private readonly IEmailSenderService _emailSenderService;
        private readonly IEmailTemplateService _emailTemplateService;

        public EmailService(IEmailMessageService emailMessageService, IEmailSenderService emailSenderService, IEmailTemplateService emailTemplateService)
        {

            _emailMessageService = emailMessageService;
            _emailSenderService = emailSenderService;
            _emailTemplateService = emailTemplateService;
        }


        public IQueryable<EmailMessage> GetMessage()
        {


        }
    }

    public interface IEmailTemplateService
    {
        IEnumerable<EmailTemplates> GetTemplates(IEnumerable<User> users);
    }

    public class EmailTemplateService : IEmailTemplateService
    {
###Implement EmailTemplateService

        Description
        EmailtTemplateService creats EmailTemplate model and manages different types of templates.This service builds placeholder collection with values based on given category and user

        Requirements
        -Create EmailTemplate model
        -Manages differemt type of templates
        -finds tokens from templates, returns placeholder data

        Deliverables
        service that creats EmailTemplate model, return placeholder data of templates
        public IEnumerable<EmailTemplates> GetTemplates(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                var fullName = $"{user.FirstName} {user.LastName}";

                if (user.Status == Status.Registreted)
                {
                    yield return new EmailTemplates(
                        MessageConstants.RegistretedBody.Replace("{{fullName}}", fullName),
                        MessageConstants.RegistretedSubject);
                }
                else if (user.Status == FtpStatusCode.Deleted)
                {
                    yield return new EmailTemplates(
                        MessageConstants.DeletedBody.Replace("{{fullName}}", fullName),
                        MessageConstants.DeletedSubject);
                }
            }
        }
    }

    public interface IEmailMessageService
    {

    }
    public class EmailMessageService : IEmailMessageService
    {
        service that return EmailMessage model
        ###Implement EmailMessageService

        Description
        EmailMessageService is service that should convert EmailTemplate model to EmailMessage model

        Requirements
        - creates EmailMessage model
        -converts EmailTemplate model to EmailMessage model
        - should return EmailMessage model

        Deliverables



    }

    public interface IEmailSenderService
    {
        IEnumerable<EmailMessage> SendEmail(IEnumerable<EmailMessage> messages);

    }

    public class EmailSenderService : IEmailSenderService
    {
        Description
        Implement an EmailService that sends given email to given user.

        Requirements
        should send given email and return EmailMessage model
        Deliverables
        service that sends an email to given email address
        public async Task SendEmail(IEnumerable<EmailMessage> messages)
        {
            var smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
            smtp.EnableSsl = true;

            foreach (var message in messages)
            {
                var mail = new MailMessage(message.SenderAddress, message.ReceiverAddress);
                mail.Subject = message.Subject;
                mail.Body = message.Body;

                await smtp.SendMailAsync(mail);
            }
        }
    }

    public static void Main(string[] args)
    {
        var hello = "jsbdsa";
    }
}


//while (true)
//{
//    var email = Console.ReadLine();
//    Console.WriteLine(Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"));

//    //Console.WriteLine(!string.IsNullOrEmpty(name)
//    //                    && char.IsUpper(name[0])
//    //                    && name.All(letter => char.IsLetter(letter)));
//}




