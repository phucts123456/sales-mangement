

namespace SaleManagementDAL.Dtos
{
	public class CustomerDto
	{
		public sbyte CustomerId { get; set; }
		public string CustomerName { get; set; } = null!;
		public string Address { get; set; } = null!;
		public string PhoneNumber { get; set; } = null!;
	}
}
