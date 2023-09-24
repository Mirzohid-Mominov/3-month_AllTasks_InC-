//N38 - HT1

//User modeli(id - guid, firstname, lastname, email address)

//UsersContainer modelini yarating

//unda quyidagi memberlar bo'lsin
//- consturctor - default constructor bo'lsin
//- constructor - userlar kolleksiyasini qabul qiladigan bo'lsin ( array, list yoki nima IEnumerable bo'lsa ham )
//-indexer - id bo'yicha bitta value qaytaradigan
//- indexer - keyword bo'ycha bitta value qaytaradigan
//- indexer - index bo'yicha bitta value qaytaradigan ( array ga o'xshab )
//-unda IEnumerable interfeysini implement qiling
//- va userlarni saqlash uchun biror kolleksiya

//- UsersContainer dan bitta instance oling
//- LINQ methodlarini foydalanib query qiling
//- indexer lar dan foydalanib ekranga bir nechta user larni chiqaring



using N38_HT1;

var userList = new List<User>()
{
    new User("Mirzohid", "Mominov","momirzohid4@gmail.com"),
    new User("Asilbek", "Suyunov", "fghjkbvcxcvbne3245"),
    new User("Shoxrux", "Qayumo", "rtyuioiuytdgwe4e2")
};

var userContainer = new UsersContainer(userList);

var query = userContainer.Where(user => user.EmailAddress.Contains("gmail.com"));
Console.WriteLine("Emaili haqiqiy bolganlar : ");

foreach(var user in query)
    Console.WriteLine(user + "\n");

Console.WriteLine(userContainer[userContainer.LastOrDefault().Id]);
