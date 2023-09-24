using N37_HT_PipeLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//NotificationManagementService
//- NotifyUsers - userlarga notification jo'natsin

namespace N37_HT_PipeLine.Services
{
    public class NotificationManagementService
    {
        private EmailSenderService _emailSenderService;
        private EmailService _emailService;
        private EmailTemplateService _emailTemplateService;
        private UserService _userService;

        public NotificationManagementService(UserService userService, EmailSenderService emailSenderService, EmailService emailService, 
            EmailTemplateService emailTemplateService)
        {
            _emailSenderService = emailSenderService;
            _emailService = emailService;
            _userService = userService;
            _emailTemplateService = emailTemplateService;
        }

        public async Task  NotifyUsers()
        {
            var users = _userService.GetUsers();
            var templates = _emailTemplateService.GetTemplates(users);
            var messages = _emailService.GetMessages(templates, users);
            await _emailSenderService.SendEmail(messages);
        }
    }
}
