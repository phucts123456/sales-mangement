

using SaleManagementDAL.DAO;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
using SaleManagementDAL.Repository.Abstraction;

namespace SaleManagementDAL.Repository
{
	public class EmployeeRepository : IEmployeeRepository
	{
		public (bool result, string reason) Add(EmployeeDto employee) => EmployeeDAO.Instance.AddEmployee(employee);
	

		public IEnumerable<EmployeeDto> GetAll() => EmployeeDAO.Instance.GetEmployees();

		public (bool result, string reason) Remove(EmployeeDto employee)
		 => EmployeeDAO.Instance.RemoveEmployee(employee);

		public (bool result, string reason) Update(EmployeeDto employee)
		 => EmployeeDAO.Instance.UpdateEmployee(employee);
	}
}
