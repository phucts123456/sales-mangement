using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Dtos
{
	public class OrderDetailDto
	{
		public sbyte OrderId { get; set; }
		public sbyte ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal RetailPrice { get; set; }
		public decimal Discount { get; set; }
		public decimal Total { get; set; }
	}
}
