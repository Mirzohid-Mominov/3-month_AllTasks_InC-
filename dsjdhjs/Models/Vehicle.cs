using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Vehicle: A record with properties for a vehicle's make, model, and year.

namespace N36_HT2.Models
{
    public record Vehicle(string Make, string Model, DateTime Year);
}
