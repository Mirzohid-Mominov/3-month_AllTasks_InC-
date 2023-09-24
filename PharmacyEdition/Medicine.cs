using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyEdition
{
    public class Medicine
    {
        public Medicine(int id, string name, double price, DateTime expirationDate, int leftCount, string description, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Price = price;
            ExpirationDate = expirationDate;
            LeftCount = leftCount;
            Description = description;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        public Medicine() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get ; set; }
        public DateTime ExpirationDate { get; set; }
        public int LeftCount { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
