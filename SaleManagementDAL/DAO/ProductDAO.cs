using AutoMapper;
using AutoMapper.QueryableExtensions;
using SaleManagementDAL.Core;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagementDAL.DAO
{
	public class ProductDAO
	{
		private static ProductDAO instance = null;
		private static readonly object instanceLock = new object();
		private ProductDAO() { }
		public static ProductDAO Instance { get 
			{ 
				lock(instanceLock)
				{
					if(instance == null)
					{
						instance = new ProductDAO();
					}
				}
				return instance;
			} 
		}
		private static IMapper GetMappingConfig()
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			return new Mapper(config);
		}
		public IEnumerable<ProductDto> GetProducts()
		{
			//var dest = mapper.Map<Source, Dest>(new Source());
			var saleManagementContext = new sales_managementContext();
			return saleManagementContext.Products.ProjectTo<ProductDto>(GetMappingConfig().ConfigurationProvider).ToList();
		}
		public (bool result, string reason) AddProduct(ProductDto productDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var product = GetMappingConfig().Map<Product>(productDto);
				saleManagementContext.Products.Add(product);
				if (saleManagementContext.SaveChanges() > 0)
				{
					return (true, "");
				}
			}
			catch (Exception ex)
			{
				return (false, "Add failed. " + ex.ToString());
			}
			return (false, "Add failed. Unknow exception.");
		}
		public (bool result, string reason) UpdateProduct(ProductDto productDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var product = GetMappingConfig().Map<Product>(productDto);
				saleManagementContext.Products.Update(product);
				if (saleManagementContext.SaveChanges() > 0)
				{
					return (true, "");
				}
			}
			catch (Exception ex)
			{
				return (false, "Add failed. " + ex.ToString());
			}
			return (false, "Update failed. Unknow exception.");
		}
		public (bool result, string reason) RemoveProduct(ProductDto productDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var product = GetMappingConfig().Map<Product>(productDto);
				saleManagementContext.Products.Remove(product);
				if (saleManagementContext.SaveChanges() > 0)
				{
					return (true, "");
				}
			}
			catch (Exception ex)
			{
				return (false, "Remove failed. " + ex.ToString());
			}
			return (false, "Remove failed. Unknow exception.");
		}
	}
}
