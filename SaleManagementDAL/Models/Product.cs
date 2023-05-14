using System;
using System.Collections.Generic;

namespace SaleManagementDAL.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public sbyte ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public sbyte MaterialId { get; set; }
        public int Quantity { get; set; }
        public decimal CostOfGood { get; set; }
        public decimal RetailPrice { get; set; }
        public string Image { get; set; } = null!;
        public string? Note { get; set; }

        public virtual Material Material { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
