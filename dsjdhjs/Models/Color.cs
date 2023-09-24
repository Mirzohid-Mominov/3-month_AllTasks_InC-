using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Color: A struct with properties for the red, green, and blue values of a color.

namespace N36_HT2.Models
{
    public struct Color
    {
        // Properties for the red, green, and blue values
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }

        // Constructor to initialize the color with RGB values
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
