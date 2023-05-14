using SaleManagementDAL.DAO;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Repository.Abstraction;

namespace SaleManagementDAL.Repository
{
	public class MaterialRepository : IMaterialRepository
	{
		public (bool result, string reason) Add(MaterialDto material) => MaterialDAO.Instance.AddMaterial(material);

		public IEnumerable<MaterialDto> GetAll() => MaterialDAO.Instance.GetMaterials();

		public (bool result, string reason) Remove(MaterialDto material) => MaterialDAO.Instance.RemoveMaterial(material);

		public (bool result, string reason) Update(MaterialDto material) => MaterialDAO.Instance.UpdateMaterial(material);
	}
}
