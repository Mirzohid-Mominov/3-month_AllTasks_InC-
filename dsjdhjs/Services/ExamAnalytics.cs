using N36_HT2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Services
{
    public class ExamAnalytics
    {
        private UserSevice _userSevice;
        private ExamScoreService _examScore;

        public ExamAnalytics(UserSevice userSevice, ExamScoreService examScoreService)
        {
            _userSevice = userSevice;
            _examScore = examScoreService;
        }

        public IEnumerable<(string FullName, int Score)> GetScores()
        {
            return _userSevice.GetAsync().Select(user =>
            {
                var fullName = $"{user.FirstName} {user.LastName}";
                var score = _examScore.GetByIdAsync(user.Id).Score;
                return (fullName, score);
            });
        }
    }
}
