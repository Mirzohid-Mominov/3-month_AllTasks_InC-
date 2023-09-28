//N43 - HT1

//User model(id, firstName, lastName, isActive )

//UserService(Users)
//EmployeeService

//- CreatePerformanceRecordAsync(id) - berilgan userni fullnami bilan fayl yaratsin

//PerformanceService

//- ReportPerformanceAsync ( id ) -berilgan userni fullname bilan yaratilgan faylni ochib, ichiga "All good :)" deb yozsin

//AccountService 
//- CreateReportAsync ( id ) -berilgan user uchun report fayl yaratib, ichini to'ldirish uchun tepadagi service lardan foydalansin

//- bunda 2 ta service bir paytda faylga access qilishi mumkinligi uchun mutex dan foydalaning
//- lekin AccountSerivce.CreateReportAsync ichida serivce lar ishini tezlashtirish uchun task continuation dan foydalaning



using N43_HT1;

var user = new User()
{ 
    Id = 1,
    FirstName = "Mirzohid",
    LastName = "Mominov",
};

var userService = new UserService();
userService.Create(user);

var employeeService = new EmployeeService(userService);
var perforManceService = new PerformanceService(userService);

var accountService = new AccountService(employeeService, perforManceService);

accountService.CreateReportAsync(user.Id);