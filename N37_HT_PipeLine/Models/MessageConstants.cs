using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//masalan 
//- registered user - Hi {{FullName}}, welcome to our system 
//- deleted user - Dear {{FullName}}, We are sorry to inform you that your account has been deleted from our system. This action was taken because [reason for account deletion].

namespace N37_HT_PipeLine.Models
{
    public static class MessageConstants
    {
        public const string RegisteredBody = "Hi {{FullName } }";
        public const string RegisteredSubject = "welcome to our system!!";

        public const string DeletedBody = "Dear {{FullName}}";
        public const string DeletedSubject = "We are sorry to inform you that your account has been deleted from our system";

        public const string SenderEmailAddress = "momirzohid4@gmail.com";
    }

}

