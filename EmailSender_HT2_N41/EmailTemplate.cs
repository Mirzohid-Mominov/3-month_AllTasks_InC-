using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender_HT2_N41
{
    public class EmailTemplate
    {
        public EmailTemplate(User user, string subject, string body)
        {
            User = user;
            Subject = subject;
            Body = body;
        }

        public User User { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
