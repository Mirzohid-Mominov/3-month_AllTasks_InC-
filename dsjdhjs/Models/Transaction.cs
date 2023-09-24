using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Transaction: A record with properties for a transaction's ID, date, and amount.

namespace N36_HT2.Models
{
   public record Transaction(Guid Id, DateTime Date, int Count);
}
