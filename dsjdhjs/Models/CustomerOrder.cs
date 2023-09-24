using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CustomerOrder: A record with properties for a customer's name, email, and a list of orders.

namespace N36_HT2.Models
{
    public record CustomerOrder(string CustomerName, string Email, List<Order> Oders);
}
