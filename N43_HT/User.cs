using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
//- lekin AccountService.CreateReportAsync ichida serivce lar ishini tezlashtirish uchun task continuation dan foydalaning

namespace N43_HT
{
    public class User
    {
        public Guid id { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public User(string firstName, string lastName, bool isActive)
        {
            this.id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            IsActive = isActive;
        }
    }
}
