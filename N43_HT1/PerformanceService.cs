﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//PerformanceService

//- ReportPerformanceAsync ( id ) -berilgan userni fullname bilan yaratilgan faylni ochib, ichiga "All good :)" deb yozsin

namespace N43_HT1
{
    public class PerformanceService
    {
        private readonly UserService _userService;
        private readonly EmployeeService _employeeService;

        private readonly Mutex _mutex = new(false, "mutex");
        public PerformanceService(UserService userService)
        {
           _userService = userService;
        }
        public async Task ReportPerformanceAsync(int id, string filePath)
        {
            _mutex.WaitOne();
            try
            {
                File.WriteAllText(filePath, "All good :)");
            }
            catch(Exception ex) 
            {
                await Console.Out.WriteLineAsync(ex.Message);
            }

            _mutex.ReleaseMutex();
        }
    }
}


