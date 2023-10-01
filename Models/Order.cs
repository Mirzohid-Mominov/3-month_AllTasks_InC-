using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_N45_HT1
{
    public class Order
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public Guid UserId { get; set; }
    }
}
