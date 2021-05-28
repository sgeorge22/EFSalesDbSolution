using System;
using System.Collections.Generic;

#nullable disable

namespace EFSalesDb.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
