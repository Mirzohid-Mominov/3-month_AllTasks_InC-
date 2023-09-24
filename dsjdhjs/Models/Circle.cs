using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Circle: A struct with properties for the radius and center point of a circle.

namespace N36_HT2.Models
{
    public struct Circle
    {
        public float Radius;
        public float Center;

        public Circle(float radius, float center)
        {
            Radius = radius;
            Center = center;
        }
    }
}
