using FirstCrudAPI_Hometask.DataAccess;
using FirstCrudAPI_Hometask.Models;
using System.Linq.Expressions;

namespace FirstCrudAPI_Hometask.Services
{
    public class UserService
    {
        private readonly IDataContext _dataContext;

        public UserService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<User> Get(Expression<Func<User, bool>> predicate)
        {
            return _dataContext.Users.Where(predicate.Compile()).AsQueryable();
        }

        public ValueTask<ICollection<User>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellation = default)
        {
            var users = _dataContext.Users.Where(user => ids.Contains(user.Id));
            return new ValueTask<ICollection<User>>(users.ToList());
        }

        public ValueTask<User?> GetByIdAsync(Guid id, CancellationToken cancellation = default)
        {
            var user = _dataContext.Users.FirstOrDefault(user => user.Id == id);
            return new ValueTask<User?>(user);
        }

        public async ValueTask<User> CreateAsync(User user, bool saveChanges = true, CancellationToken cancellation = default)
        {
            await _dataContext.Users.AddAsync(user, cancellation);
            
            if(saveChanges)
            {
                await _dataContext.SaveChangesAsync();
            }

            return user;
        }

        public async ValueTask<User> UpdateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var foundUser = _dataContext.Users.FirstOrDefault(x => x.Id == user.Id);
            if (user is null)
                throw new InvalidOperationException("user not found with this information!");

            foundUser.FirstName = user.FirstName;
            foundUser.LastName = user.LastName;
            foundUser.EmailAddress = user.EmailAddress;

            await _dataContext.SaveChangesAsync();
            return foundUser;
        }

        public async ValueTask<User> DeleteAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var foundUser = await GetByIdAsync(user.Id, cancellationToken);
            if(foundUser is null)
                throw new InvalidOperationException("user not found with this information!");
            
            await _dataContext.Users.RemoveAsync(foundUser, cancellationToken);
            await _dataContext.SaveChangesAsync();
            return foundUser;
        }

        public async ValueTask<User> DeleteAsync(Guid guid, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var foundUser = await GetByIdAsync(guid, cancellationToken);
            if(foundUser is null)
                throw new InvalidOperationException("user not found with this information!");

            await _dataContext.Users.RemoveAsync(foundUser, cancellationToken);
            await _dataContext.SaveChangesAsync();
            return foundUser;
        }
    }
}
