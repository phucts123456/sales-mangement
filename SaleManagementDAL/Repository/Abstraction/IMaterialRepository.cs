using SaleManagementDAL.Dtos;

namespace SaleManagementDAL.Repository.Abstraction
{
	public interface IMaterialRepository
	{
		IEnumerable<MaterialDto> GetAll();
		(bool result, string reason) Add(MaterialDto material);
		(bool result, string reason) Update(MaterialDto material);
		(bool result, string reason) Remove(MaterialDto material);
	}
}
