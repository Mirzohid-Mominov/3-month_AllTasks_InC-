using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EmailTemplate - email shabloni ( subject, body )

namespace N37_HT_PipeLine.Models
{
    public class EmailTemplates
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public EmailTemplates(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
    }
}
