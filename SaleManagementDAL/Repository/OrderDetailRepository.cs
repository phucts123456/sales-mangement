using SaleManagementDAL.DAO;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
using SaleManagementDAL.Repository.Abstraction;

namespace SaleManagementDAL.Repository
{
	public class OrderDetailRepository : IOrderDetailRepository
	{
		public (bool result, string reason) Add(OrderDetailDto orderDetail) => OrderDetailDAO.Instance.AddOrderDetail(orderDetail);

		public IEnumerable<OrderDetailDto> GetAll(sbyte orderid) => OrderDetailDAO.Instance.GetOrderDetails(orderid);
		public (bool result, string reason) Remove(OrderDetailDto orderDetail) => OrderDetailDAO.Instance.RemoveOrderDetail(orderDetail);

		public (bool result, string reason) Update(OrderDetailDto orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
	}
}
