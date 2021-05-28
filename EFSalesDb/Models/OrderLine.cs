using System;
using System.Collections.Generic;

#nullable disable

namespace EFSalesDb.Models
{
    public partial class OrderLine
    {
        public int Id { get; set; }
        public int OrdersId { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Order Orders { get; set; }
    }
}
