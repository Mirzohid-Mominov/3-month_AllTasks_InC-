using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Triangle: A struct with properties for the three vertices of a triangle.

namespace N36_HT2.Models
{
    public struct Triangle
    {
        public Point Vertice { get; }
        public Point Vertice1 { get; }
        public Point Vertice2 { get; }

        public Triangle(Point vertice, Point vertice1, Point vertice2)
        {
            Vertice = vertice;
            Vertice1 = vertice1;
            Vertice2 = vertice2;
        }
    }
}
