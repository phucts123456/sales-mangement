using SaleManagementDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Dtos
{
	public class EmployeeDto
	{
		public sbyte EmployeeId { get; set; }
		public string EmployeeName { get; set; } = null!;
		public string Sex { get; set; } = null!;
		public string Address { get; set; } = null!;
		public string PhoneNumber { get; set; } = null!;
		public DateTime DateOfBirth { get; set; }

	}
}
