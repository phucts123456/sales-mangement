using System;
using System.Collections.Generic;

namespace SaleManagementDAL.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public sbyte OrderId { get; set; }
        public sbyte EmployeeId { get; set; }
        public sbyte CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
