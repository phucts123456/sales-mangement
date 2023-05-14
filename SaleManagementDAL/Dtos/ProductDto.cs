using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Dtos
{
	public class ProductDto
	{
		public sbyte ProductId { get; set; }
		public string ProductName { get; set; } = null!;
		public sbyte MaterialId { get; set; }
		public int Quantity { get; set; }
		public decimal CostOfGood { get; set; }
		public decimal RetailPrice { get; set; }
		public string Image { get; set; } = null!;
		public string? Note { get; set; }

	}
}
