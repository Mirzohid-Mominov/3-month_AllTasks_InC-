using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Interfaces
{
    public interface IExamScoreService
    {
        ValueTask<ICollection<ExamScore>> GetAsync(IEnumerable<Guid> ids);
        ExamScore GetByIdAsync(Guid id);
        List<ExamScore> AddAsync(ExamScore examScore);

        ValueTask<ExamScore> CreateAsync(ExamScore examScore);

        ExamScore UpdateAsync(ExamScore examScore);

        ExamScore DeleteAsync(ExamScore examScore);
    }
}
