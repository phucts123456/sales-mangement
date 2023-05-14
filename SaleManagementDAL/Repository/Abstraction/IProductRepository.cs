using SaleManagementDAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Repository.Abstraction
{
	public interface IProductRepository
	{
		IEnumerable<ProductDto> GetAll();
		(bool result, string reason) Add(ProductDto Product);
		(bool result, string reason) Update(ProductDto Product);
		(bool result, string reason) Remove(ProductDto Product);
	}
}
