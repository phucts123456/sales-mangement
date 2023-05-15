using SaleManagementDAL.DAO;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
using SaleManagementDAL.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Repository
{
	public class OrderRepository : IOrderRepository
	{
		public (bool result, string reason) Add(OrderDto order) => OrderDAO.Instance.AddOrder(order);

		public IEnumerable<OrderDto> GetAll() => OrderDAO.Instance.GetOrders();
		public (bool result, string reason) Remove(OrderDto order) => OrderDAO.Instance.RemoveOrder(order);

		public (bool result, string reason) Update(OrderDto order) => OrderDAO.Instance.UpdateOrder(order);
	}
}
