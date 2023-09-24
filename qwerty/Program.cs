using N38_C.Models;

var filesConteiner = new FilesContainer("D:\\3-month_AllTasks_InC#\\qwerty\\Services");
foreach (var file in filesConteiner)
{
    Console.WriteLine(file);
}