using N36_HT2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Services
{
    public class ExamScoreService : IExamScoreService
    {
        private List<ExamScore> _examScore;

        public ExamScoreService()
        {
            _examScore = new List<ExamScore>();
        }
        public ValueTask<ICollection<ExamScore>> GetAsync(IEnumerable<Guid> ids)
        {
            var examScores = _examScore.Where(score => ids.Contains(score.Id));
            return new ValueTask<ICollection<ExamScore>>(examScores.ToList());
        }

        public ExamScore GetByIdAsync(Guid id)
        {
             var examScore = _examScore.FirstOrDefault(score => score.UserId == id);
            return examScore;
        }

        public List<ExamScore> AddAsync(ExamScore examScore)
        {
            var foundUser = _examScore.FirstOrDefault(users => users.Id == examScore.Id);
            if (foundUser != null)
                throw new InvalidOperationException("You are already existed");

            _examScore.Add(examScore);
            Console.WriteLine("Successfully Added!");
            return _examScore;
        }

        public async ValueTask<ExamScore> CreateAsync(ExamScore examScore)
        {
            _examScore.Add(examScore);
            return examScore;
        }

        public  ExamScore UpdateAsync(ExamScore examScore)
        {
            var foundScore = _examScore.FirstOrDefault(score => score.Id == examScore.Id);
            if (foundScore != null)
                throw new InvalidOperationException("You are already existed");

            _examScore.Add(examScore);
            Console.WriteLine("Successfully Added!");
            return examScore;
        }

        public ExamScore DeleteAsync(ExamScore examScore)
        {
            var foundUser = GetByIdAsync(examScore.Id);
            if (foundUser is null)
                throw new InvalidOperationException("User not found");

            _examScore.Remove(foundUser);
            return foundUser;
        }

    }
}
