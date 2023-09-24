using N37_HT_PipeLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//EmailTemplateService
//- GetTemplates - user larga mos email templatelarni yield qilib qaytarsin

namespace N37_HT_PipeLine.Services
{
    public class EmailTemplateService
    {
        public IEnumerable<EmailTemplates> GetTemplates(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                var fullName = $"{user.FirstName} {user.LastName}";

                if(user.Status == Status.Registered)
                {
                    yield return new EmailTemplates(
                        MessageConstants.RegisteredBody.Replace("{ { FullName } }", fullName),
                        MessageConstants.RegisteredSubject);
                }
                else if(user.Status ==  Status.Deleted)
                {
                    yield return new EmailTemplates(
                        MessageConstants.DeletedBody.Replace("{ { FullName } }", fullName),
                        MessageConstants.DeletedSubject);
                }
            }
        }
    }
}
