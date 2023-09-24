//N41 - HT2

//Thread Safe EmailSenderService yarating
//- bunda bitta email ketib bo'lmagunicha boshqa thread SendEmailAsync methodiga kira olmasin
//- SMTP instance ni esa constructor ichida yarating


using EmailSender_HT2_N41;

var user1 = new User("Mirzohid", "Mo'minov", "momirzohid4@gmail.com");
var user2 = new User("John", "Doe", "mirzohidmuminov04@gmail.com");

var template1 = new EmailTemplate(user1, Constants.WelcomeSubject, Constants.WelcomeBody);
var template2 = new EmailTemplate(user2, Constants.WelcomeSubject, Constants.WelcomeBody);

var sender = new Sender();

var tasks = new List<Task>
{
    new(() => sender.SendEmailAsync(template1)),
    new(() => sender.SendEmailAsync(template2))
};

Parallel.ForEach(tasks, task => task.Start());
await Task.WhenAll(tasks);
