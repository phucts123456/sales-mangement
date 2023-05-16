using SaleManagementDAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Repository.Abstraction
{
	public interface ICustomerRepository
	{
		IEnumerable<CustomerDto> GetAll();
		CustomerDto GetCustomerById(sbyte id);
		(bool result, string reason) Add(CustomerDto customer);
		(bool result, string reason) Update(CustomerDto customer);
		(bool result, string reason) Remove(CustomerDto customer);
	}
}
