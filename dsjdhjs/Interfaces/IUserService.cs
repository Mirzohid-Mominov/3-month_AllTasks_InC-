using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Interfaces
{
    public interface IUserService
    {
        List<User> GetAsync();

        ValueTask<User?> GetByIdAsync(Guid id);
        List<User> AddAsync(User user);

        ValueTask<User> CreateAsync(User user);

        ValueTask<User> UpdateAsync(User user);

        ValueTask<User> DeleteAsync(User user);
    }
}
