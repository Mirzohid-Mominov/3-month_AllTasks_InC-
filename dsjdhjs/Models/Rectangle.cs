using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rectangle: A struct with properties for the width and height of a rectangle.

namespace N36_HT2.Models
{
   public struct Rectangle
    {
        public double Width;
        public double Height;
        
        public Rectangle(double  width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
