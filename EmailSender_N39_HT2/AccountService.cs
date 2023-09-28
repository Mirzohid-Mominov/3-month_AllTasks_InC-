using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Servicelar
//- AccountService
//- undagi methodlar
//- Register(emailAddress, password)


namespace EmailSender_N39_HT2
{
    public class AccountService
    {
        private readonly EmailSenderService _emailSenderService;
        private List<User> _users;
        public AccountService(EmailSenderService emailSenderService, List<User> users)
        {
            _emailSenderService = emailSenderService;
            _users = users;
        }

        public async Task Register(IEnumerable<User> emailAddress, IEnumerable<User> password)
        {
            if (emailAddress == null)
            {
                throw new ArgumentNullException(nameof(emailAddress));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            foreach (var user in emailAddress )
            {
                _users.Add(user);
            }
        }
    }
}
