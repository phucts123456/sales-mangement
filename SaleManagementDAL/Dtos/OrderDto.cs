using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Dtos
{
	public class OrderDto
	{
		public sbyte OrderId { get; set; }
		public sbyte EmployeeId { get; set; }
		public sbyte CustomerId { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal Total { get; set; }
		public CustomerDto Customer { get; set; }
		public EmployeeDto Employee { get; set; }
	}
}
