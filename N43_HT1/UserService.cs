using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N43_HT1
{
    public class UserService
    {
        private List<User> _user;

        public UserService()
        {
            _user = new ();
        }

        public User Create(User? user)
        {
            if(user != null)
            {
                _user.Add (user);
                return user;
            }
            throw new ArgumentNullException(nameof(user), "you wrote user is null!");
        }

        public bool Delete(Guid id)
        {
            var foundUser = _user.FirstOrDefault (x => x.Id == id);
            if(foundUser != null)
            {
                _user.Remove (foundUser);
                return true;
            }
            return false;
        }

        public User? Get(Guid id)
        {
            return _user.FirstOrDefault(x => x.Id == id);
        }

        public User Update(User user)
        {
            var foundUser = Get(user.Id);
            if(foundUser != null)
            {
                foundUser.FirstName = user.FirstName;
                foundUser.LastName = user.LastName;
                foundUser.IsActive = user.IsActive;
            }
        }
    }
}
