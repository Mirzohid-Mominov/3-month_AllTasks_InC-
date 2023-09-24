using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//- ExamScore modelidan foydalaning ( id, userId, score )

namespace N36_HT2
{
    public class ExamScore
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Score { get; set; }
        public ExamScore() { }
        public ExamScore(Guid userId, int score)
        {
            Id = new Guid();
            UserId = userId;
            Score = score;
        }
    }
}
