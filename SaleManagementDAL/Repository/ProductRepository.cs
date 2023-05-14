using SaleManagementDAL.DAO;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.Repository
{
	public class ProductRepository : IProductRepository
	{
		public (bool result, string reason) Add(ProductDto Product) => ProductDAO.Instance.AddProduct(Product);
		public IEnumerable<ProductDto> GetAll() => ProductDAO.Instance.GetProducts();
		public (bool result, string reason) Remove(ProductDto Product) => ProductDAO.Instance.RemoveProduct(Product);
		public (bool result, string reason) Update(ProductDto Product) => ProductDAO.Instance.UpdateProduct(Product);
	}
}
