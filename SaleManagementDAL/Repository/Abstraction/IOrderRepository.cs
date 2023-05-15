using SaleManagementDAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Repository.Abstraction
{
	public interface IOrderRepository
	{
		IEnumerable<OrderDto> GetAll();
		(bool result, string reason) Add(OrderDto order);
		(bool result, string reason) Update(OrderDto order);
		(bool result, string reason) Remove(OrderDto order);
	}
}
