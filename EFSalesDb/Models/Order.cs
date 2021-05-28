using System;
using System.Collections.Generic;

#nullable disable

namespace EFSalesDb.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public virtual Customer Customer { get; set; } 
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        //virtual is important when using eframework, meaning its not in the database only in the class.
        //this is different that the virtual we used in the method to override. it is on a property
    }
}
