using N37_HT_PipeLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EmailService
//- GetMessages - berilgan template va userlardan email message larni rezult qilib qaytaradi

namespace N37_HT_PipeLine.Services
{
    public class EmailService
    {
        private List<EmailTemplates> _templates;
        private List<EmailMessage> _messages;

        //public EmailService(List<EmailTemplates> templates, List<EmailMessage> messages)
        //{
        //    _templates = templates;
        //    _messages = messages;
        //}

        public IEnumerable<EmailMessage> GetMessages(IEnumerable<EmailTemplates> emailTemplates, IEnumerable<User> users)
        {
            foreach(var item in users.Zip(emailTemplates))
            {
                yield return new EmailMessage(item.Second.Subject, item.Second.Body,
                    MessageConstants.SenderEmailAddress, item.First.EmailAddress);
            }
        }
    }
}
