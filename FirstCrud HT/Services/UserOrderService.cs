using FirstCrudAPI_Hometask.Models;
using FirstCrudAPI_Hometask.Services;

namespace FirstCrud_HT.Services
{
    public class UserOrderService
    {
        private readonly OrderService _orderService;

        public UserOrderService(OrderService orderService)
        {
            _orderService = orderService;
        }

        public IQueryable<Order> GetUserOrders(Guid userId)
        {
            return _orderService.Get(x => x.Id ==  userId);
        }
    }
}
