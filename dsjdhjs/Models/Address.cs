using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Address: A record with properties for an address's street, city, state, and zip code.

namespace N36_HT2.Models
{
    public record Address(string Street, string City, string State, string ZipCode);
}
