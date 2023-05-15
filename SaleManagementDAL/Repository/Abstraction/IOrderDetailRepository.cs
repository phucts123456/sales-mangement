using SaleManagementDAL.Dtos;

namespace SaleManagementDAL.Repository.Abstraction
{
	public interface IOrderDetailRepository
	{
		IEnumerable<OrderDetailDto> GetAll(sbyte orderId);
		(bool result, string reason) Add(OrderDetailDto orderDetail);
		(bool result, string reason) Update(OrderDetailDto orderDetail);
		(bool result, string reason) Remove(OrderDetailDto orderDetail);
	}
}
