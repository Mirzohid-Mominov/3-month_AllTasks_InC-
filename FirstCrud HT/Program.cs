
//    N48-HT1 - first CRUD API 

//- empty web API project yarating

//- User(id, firstname, lastname, emailAddress, password )
//- Order(id, amount, userId )

//- modellarini qo'shing
//- DataAccess ni qo'shing ( IDataContext, AppFileContext )
//- shu modellar uchun servicelarni qo'shing
//- UserOrders nomli composition service qo'shing

//Controller 

//-  UsersController va endpointlar 

//- api/users - get, post, put - barcha userlarni olish, user qo'shish va userni update qilish
//- api/users/:id - get - bitta userni Id bo'yicha olish
//- api/users/:id/orders - get - bitta userni barcha orderlarnini olish

//- OrdersController va endpointlar

//- api/orders - get, post, put - barcha orderlarni olish, order qo'shish va order ni update qilish
//- api/orders/:id - bitta orderni Id bo'yicha olish

//- swagger o'rnating

//PS : api configuratsiyasi va controllerlar, ular ichida servicelarni ishlatishni
//N48 darsidagi IntroB.Api project dan ko'rsangiz bo'ladi, barcha endpointlarni swagger orqali tekshiring


using FileBaseContext.Abstractions.Models.FileContext;
using FileBaseContext.Context.Models.Configurations;
using FirstCrud_HT.Services;
using FirstCrudAPI_Hometask.DataAccess;
using FirstCrudAPI_Hometask.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddScoped<IDataContext, AppFileContext>(provider =>
{
    var options = new FileContextOptions<AppFileContext>
    {
        StorageRootPath = Path.Combine(builder.Environment.ContentRootPath, "Data/Storage")
    };
    var dataContext = new AppFileContext(options);
    
    return dataContext;
});


builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<OrderService>();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

await app.RunAsync();









//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();


//app.MapControllers();

//app.Run();
