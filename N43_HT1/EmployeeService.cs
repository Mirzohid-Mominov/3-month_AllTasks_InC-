using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

//EmployeeService

//- CreatePerformanceRecordAsync(id) - berilgan userni fullnami bilan fayl yaratsin

namespace N43_HT1
{
    public class EmployeeService
    {
        private List<User> _users;
        public EmployeeService()
        {
            _users = new List<User>();
        }
        public async Task CreatePerformanceRecordAsync(Guid id)
        {
            var foundUser = _users.FirstOrDefault(x => x.Id.Equals(id));

            var fullName = $"{foundUser.FirstName} {foundUser.LastName}";
           
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            var fileName = $"{fullName}.txt";
            var filePath = Path.Combine(directoryPath, fileName);

            File.Create(filePath).Close();
            //var file = File.Open(filePath, FileMode.OpenOrCreate);

            //JsonSerializer.Serialize(file, "All Good");
            //file.Flush();
            //file.Close();
            //Console.WriteLine("hello");
        }
    }
}
