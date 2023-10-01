// N45 - HT1

//User - (id, firstName)
//Order - (id, amount, userId)
//OrderProduct(id, productId, orderId, count)
//Product - (id, name, price)

//- barcha modellar uchun kolleksiyalarni yarating va ichiga ma'lumot qo'shing
//- barcha kolleksiyalarni LINQ query syntax dan foydalanib join qilib, query yasang
//- o'sha querydan berilgan userni Id si bo'yicha sotib olingan barcha product nomlarini distinct qilib chiqaring


using Linq_N45_HT1;

var random = new Random();

var users = new List<User>()
{
    new User() {Id = Guid.NewGuid(), FirstName = "Asilbek"},
    new User() {Id = Guid.NewGuid(),FirstName = "HolMurod"},
    new User() {Id = Guid.NewGuid(), FirstName = "Halilbek"},
    new User() {Id = Guid.NewGuid(), FirstName = "Shoyadbek"},
};

var products = new List<Product>()
{
    new Product(){Id = Guid.NewGuid(), Name = "Iphone", Price = 1200000},
    new Product(){Id = Guid.NewGuid(), Name = "Redmi", Price = 3230000},
    new Product(){Id = Guid.NewGuid(), Name = "Nokia", Price = 1290000},
    new Product(){Id = Guid.NewGuid(), Name = "Samsung", Price = 7800254}
};

var orderProducts = new List<OrderProduct>()
{
    new OrderProduct(){Id = Guid.NewGuid(), Count = 3, OrderId = Guid.NewGuid(), ProductId = Guid.NewGuid()},
    new OrderProduct(){Id = Guid.NewGuid(), Count = 89, OrderId = Guid.NewGuid(), ProductId = Guid.NewGuid()},
    new OrderProduct(){Id = Guid.NewGuid(), Count = 35, OrderId = Guid.NewGuid(), ProductId = Guid.NewGuid()},
    new OrderProduct(){Id = Guid.NewGuid(), Count = 64, OrderId = Guid.NewGuid(), ProductId = Guid.NewGuid()}
};

var orders = new List<Order>()
{
    new Order() {Id = Guid.NewGuid(), Amount = 38, UserId = Guid.NewGuid()},
    new Order() {Id = Guid.NewGuid(),  Amount = 83, UserId = Guid.NewGuid()},
    new Order() {Id = Guid.NewGuid(), Amount = 49,  UserId = Guid.NewGuid()},
    new Order() {Id = Guid.NewGuid(),  Amount = 18,  UserId = Guid.NewGuid()}
};


var query = (from user in users
             join order in orders on user.Id equals order.UserId
             join orderProduct in orderProducts on order.Id equals orderProduct.OrderId
             join product in products on orderProduct.ProductId equals product.Id
             where user.Id == order.UserId
             select product.Name).Distinct();

query.ToList().ForEach(Console.WriteLine);