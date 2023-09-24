using N37_HT_PipeLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//UserService 
//- GetUsers - userlarni yield qilib jo'natsin

namespace N37_HT_PipeLine.Services
{
    public class UserService
    {
        public List<User> _user;

        public UserService()
        {
            _user = new List<User>();
        }

        public IEnumerable<User> GetUsers()
        {
            foreach(var user in _user)
            {
                yield return user;
            }
        }
    }
}
