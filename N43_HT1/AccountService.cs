using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N43_HT1
{
    public class AccountService
    {
        private readonly EmployeeService _employeeService;
        private readonly PerformanceService _performanceService;

        public AccountService(EmployeeService employeeService, PerformanceService performanceService)
        {                    
            _employeeService = employeeService;
            _performanceService = performanceService;
        }

        public async Task CreateReportAsync(int id)
        {
             var result = _employeeService.CreatePerformanceRecordAsync(id);

                 _performanceService.ReportPerformanceAsync(id, result.Result);
        }
    }
}
