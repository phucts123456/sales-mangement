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
	public class CustomerRepository : ICustomerRepository
	{
		public (bool result, string reason) Add(CustomerDto customer) => CustomerDAO.Instance.AddCustomer(customer);
		public IEnumerable<CustomerDto> GetAll() => CustomerDAO.Instance.GetCustomers();

		public CustomerDto GetCustomerById(sbyte id) => CustomerDAO.Instance.GetCustomerById(id);

		public (bool result, string reason) Remove(CustomerDto customer) => CustomerDAO.Instance.RemoveCustomer(customer);

		public (bool result, string reason) Update(CustomerDto customer) => CustomerDAO.Instance.UpdateCustomer(customer);
	
	}
}
