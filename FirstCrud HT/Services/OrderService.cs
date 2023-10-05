using FirstCrudAPI_Hometask.DataAccess;
using FirstCrudAPI_Hometask.Models;
using System.Linq.Expressions;

namespace FirstCrud_HT.Services
{
    public class OrderService
    {
        private readonly IDataContext _dataContext;
        public OrderService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<Order> Get(Expression<Func<Order, bool>> predicate)
        {
            return _dataContext.Orders.Where(predicate.Compile()).AsQueryable();
        }

        public ValueTask<ICollection<Order>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellation = default)
        {
            var user = _dataContext.Orders.Where(x => ids.Contains(x.Id));
            return new ValueTask<ICollection<Order>>(user.ToList());
        }

        public ValueTask<Order?> GetByIdAsync(Guid id, CancellationToken cancellation = default)
        {
            var user = _dataContext.Orders.FirstOrDefault(x => x.Id == id);
            return new ValueTask<Order?>(user);
        }

        public async ValueTask<Order> CraeteAsync(Order order, bool savechanges = true, CancellationToken cancellationToken = default)
        {
            await _dataContext.Orders.AddAsync(order);
            if(savechanges)
                await _dataContext.SaveChangesAsync();

            return order;
        }

        public async ValueTask<Order> UpdateAsync(Order order, CancellationToken cancellationToken = default)
        {
            var foundUser = _dataContext.Orders.FirstOrDefault(x => x.Id == order.Id);
            if (foundUser is null)
                throw new InvalidOperationException("User not found");


            foundUser.Amount = order.Amount;
            foundUser.UserId = order.UserId;
            _dataContext.SaveChangesAsync();

            return foundUser;
        }

        public async ValueTask<Order> DeleteAsync(Order order, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var foundUser = await GetByIdAsync(order.Id, cancellationToken);
            if (foundUser is null)
                throw new InvalidOperationException("User not fouund with this information");

            await _dataContext.Orders.RemoveAsync(foundUser, cancellationToken);
            await _dataContext.SaveChangesAsync();
            return foundUser;
        }

        public async ValueTask<Order> DaleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var foundUser = await GetByIdAsync(id, cancellationToken);
            if (foundUser is null)
                throw new InvalidOperationException("User not fouund with this information");

            await _dataContext.Orders.RemoveAsync(foundUser, cancellationToken);
            await _dataContext.SaveChangesAsync();
            return foundUser;
        }
    }
}
