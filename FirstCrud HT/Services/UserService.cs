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
    }
}
