//N37 - HT1

//Pipeline - dasturlashda pipeline bir nechta narsani ketma-ket process qiladigan narsa pipeline deyiladi, masalan, fayl processing pipeline, bunda faylni o'qib olish,
//ichidagi narsani process qilish, tarjima qilish, boshqa formatga o'tkazish va yana faylga yozib qo'yish amallari bo'lishi mumkin.
//Bunda shu amallar bitta method ichiga yozilmasdan pipeline ko'rinishida yozilsa qulay bo'ladi

//Modellar 

//User - FirstName, LastName, Status ( Registered, Active, Deleted ) 
//EmailTemplate - email shabloni ( subject, body )
//EmailMessage - jo'natilgan email detallari ( subject, body, senderAddress, receiverAddress )


//Servicelar

//UserService 
//- GetUsers - userlarni yield qilib jo'natsin

//NotificationManagementService
//- NotifyUsers - userlarga notification jo'natsin

//EmailService
//- GetMessages - berilgan template va userlardan email message larni rezult qilib qaytaradi

//EmailTemplateService
//- GetTemplates - user larga mos email templatelarni yield qilib qaytarsin

//masalan 
//- registered user - Hi {{FullName}}, welcome to our system 
//- deleted user - Dear {{FullName}}, We are sorry to inform you that your account has been deleted from our system. This action was taken because [reason for account deletion].

//EmailSenderService            
//- SendEmails - berilgan email message larni userga jo'natsin

//Organization : 
//-NotificationManagementService - composition service, uni ichida UserService, EmailTemplateService va EmailSenderService dan instance bo'ladi
//- bu composition service boshqa servicelardagi yield return qiladigan iterator methodlarni bir biriga ulab pipeline qilib ishlatadi : 

//var users = _userService.GetUsers();
//var templates = _emailTemplateService.GetTemplates(users);
//var messages = _emailService.GetMessages(templates, users);
//await _emailSenderService.SendEmailsAsync(messages);

//-bir nechta userlarni qo'shing 
//- NotificationManagementService orqali notify qilib ko'ring


using N37_HT_PipeLine.Models;
using N37_HT_PipeLine.Services;

var users = new List<User>
{
    new User("Mirzohid", "Mominov", "momirzohid4@gmail.com", Status.Active),
    new User("Abdura", "Abdura", "Abdura@gm.com", Status.Registered)
};

var templates = new List<EmailTemplates>
{
    new EmailTemplates("First subject", "First subject's body"),
    //new EmailTemplate("Second subject", "Second subject's body"),
};

var result = users.Zip(templates);
Console.WriteLine(result.Last().First.FirstName);


var userService = new UserService();
var emailService = new EmailService();

var emailTemplateService = new EmailTemplateService();
var emailSenderService = new EmailSenderService();

var notificationService = new NotificationManagementService(userService, emailSenderService, emailService,  emailTemplateService);

userService._user.Add(new User("Abdura", "Abdura", "abdura52.uz@gmail.com", Status.Deleted));
userService._user.Add(new User("Habiba", "Sattorova", "sattorovahabiba00@gmail.com", Status.Registered));
await notificationService.NotifyUsers();