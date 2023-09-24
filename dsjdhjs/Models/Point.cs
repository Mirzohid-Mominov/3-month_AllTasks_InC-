using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Point: A struct with properties for the x and y coordinates of a point in 2D space.

namespace N36_HT2.Models
{
    public struct Point
    {
        public double X;
        public double Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
