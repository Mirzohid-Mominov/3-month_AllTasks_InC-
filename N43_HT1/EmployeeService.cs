//EmployeeService

//- CreatePerformanceRecordAsync(id) - berilgan userni fullnami bilan fayl yaratsin

namespace N43_HT1
{
    public class EmployeeService
    {
        private readonly UserService _userService;
        private Mutex _mutex = new(false, "OpenFileMutex");

        public EmployeeService(UserService userService)
        {
            _userService = userService;
        }
        public async Task<string> CreatePerformanceRecordAsync(int id)
        {

            _mutex.WaitOne();

            var foundUser = _userService.Get(id);
            if (foundUser != null)
            {
                var fullName = $"{foundUser.FirstName} {foundUser.LastName}.txt";
                var directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var filePath = Path.Combine(directoryPath, fullName);

                File.Create(filePath).Close();

                return filePath;
            }
            _mutex.ReleaseMutex();

            return null;
        }
    }
}