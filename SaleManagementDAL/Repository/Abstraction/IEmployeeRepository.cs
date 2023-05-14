using SaleManagementDAL.Dtos;


namespace SaleManagementDAL.Repository.Abstraction
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDto> GetAll();
        (bool result, string reason) Add(EmployeeDto employee);
        (bool result, string reason) Update(EmployeeDto employee);
        (bool result, string reason) Remove(EmployeeDto employee);
    }
}
