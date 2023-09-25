using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BogusLibrary_N38_Ht2.Models
{
    public class UserAddress
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"Country : {Country}, State: {State}, City: {City}, Street: {Street}, Number: {Number}";
        }
    }
}
