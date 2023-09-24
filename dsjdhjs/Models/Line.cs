using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Line: A struct with properties for the start and end points of a line.

namespace N36_HT2.Models
{
    public struct Line
    {
        public bool Start;
        public bool End;

        public Line(bool start, bool end)
        {
            Start = start;
            End = end;
        }
    }
}
