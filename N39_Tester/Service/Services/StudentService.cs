using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N39_Tester.Service.Services
{
    public class StudentService
    {
        public IEnumerable<Student> GetAll()
        {
            string source = default;
            if(File.Exists(Constants.Student_DB))
                source = File ReadAllText(Constants.Student_DB);

            if(source is not null)
            {
                if(string.IsNullOrWhiteSpace(source))
                    var users = Fil
            }
        }
    }
}
