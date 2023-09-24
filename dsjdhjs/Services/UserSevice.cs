using N36_HT2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Services
{
    public class UserSevice : IUserService
    {
        private List<User> _user = new List<User>();

        public List<User> GetAsync()
        {
           return _user;
        }

        public ValueTask<User?> GetByIdAsync(Guid id)
        {
            var user = _user.FirstOrDefault(user => user.Id == id);
            return new ValueTask<User?>(user);
        }

        public List<User> AddAsync(User user)
        {
            var foundUser = _user.FirstOrDefault(users => users.Id == user.Id);
            if (foundUser != null)
                throw new InvalidOperationException("You are already existed");

            _user.Add(user);
            Console.WriteLine("Successfully Added!");
            return _user;
        }

        public async ValueTask<User> CreateAsync(User user)
        {

            _user.Add(user);
            return user;
        }

        public async ValueTask<User> UpdateAsync(User user)
        {
            var foundUser = _user.FirstOrDefault(searchingUser => searchingUser.Id == user.Id);

            if (foundUser is null)
                throw new InvalidOperationException("User not found");

            foundUser.FirstName = user.FirstName;
            foundUser.LastName = user.LastName;
            _user.Add(foundUser);
            return foundUser;
        }

        public async ValueTask<User> DeleteAsync(User user)
        {
            var foundUser = await GetByIdAsync(user.Id);
            if (foundUser is null)
                throw new InvalidOperationException("User not found");
            
            _user.Remove(foundUser);
            return foundUser;
        }     
    }
}
