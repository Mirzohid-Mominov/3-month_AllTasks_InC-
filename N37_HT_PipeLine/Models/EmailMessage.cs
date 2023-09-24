using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EmailMessage - jo'natilgan email detallari ( subject, body, senderAddress, receiverAddress )

namespace N37_HT_PipeLine.Models
{
    public class EmailMessage
    {
        public EmailMessage(string body, string subject, string senderAddress, string receiverAddress)
        {
            Body = body;
            Subject = subject;
            SenderAddress = senderAddress;
            ReceiverAddress = receiverAddress;
        }

        public string Body { get; set; }
        public string Subject { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
    }
}
