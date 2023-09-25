using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusLibrary_N38_Ht2.Models
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ReadTime { get; set; }
        public DateOnly CreatedDate { get; set; }

        public override string ToString()
        {
            return $"Id :{Id}, Title: {Title}, Content : {Content}, ReadTime: {ReadTime} min, CreatedDate: {CreatedDate}";
        }
    }
}
