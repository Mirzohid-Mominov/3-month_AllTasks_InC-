using System.Net.Mail;
using System.Net;
using System.Text;

var mutex = new Mutex(false, "MainMutex");

bool res;
var path = @"D:\Hello.txt";

    mutex.WaitOne();
var fileStream = File.Open(path, FileMode.OpenOrCreate);
res = fileStream.ReadByte().ToString() == "false";
var buffer = fileStream.Length;
    var fileStream2 = File.Create(@"D:\template.txt");
fileStream.Close();

if (!res)
{
    Thread.Sleep(10_000);
    buffer = fileStream2.ReadByte();
    fileStream2.Write(Encoding.UTF8.GetBytes("Hello {{User}}. Welcome!"));
    fileStream2.Close();
    
    Console.WriteLine("ok");
}
else
{
    Thread.Sleep(10_000);
    var buffer2 = Convert.ToString(fileStream2.ReadByte());
    var email = new EmailSenderService();
    await email.SendEmail(buffer2, "azizbek1820@gmail.com");
    Console.WriteLine("Email sended.");
}
    mutex.ReleaseMutex();


public class EmailSenderService
{
    public async Task SendEmail(string messages, string ReceiverAddress)
    {
        var smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
        smtp.EnableSsl = true;

        var mail = new MailMessage(ReceiverAddress, "sultonbek.rakhimov.recovery@gmail.com");
        mail.Subject = (messages.Split('.')[0] + ".");
        mail.Body = (messages.Split('.')[1] + ".").Replace("{{User}}", "Muhammadaziz");

        await smtp.SendMailAsync(mail);

    }
}