using System;
using System.Collections.Generic;

namespace SaleManagementDAL.Models
{
    public partial class OrderDetail
    {
        public sbyte OrderId { get; set; }
        public sbyte ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
