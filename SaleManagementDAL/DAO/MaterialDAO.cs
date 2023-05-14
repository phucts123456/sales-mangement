using AutoMapper;
using AutoMapper.QueryableExtensions;
using SaleManagementDAL.Core;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;

namespace SaleManagementDAL.DAO
{
	public sealed class MaterialDAO
	{
		private  static MaterialDAO instance = null;
		private readonly static object instanceLock = new object();
		public static MaterialDAO Instance { get 
			{ 
				lock(instanceLock)
				{
					if(instance == null)
					{
						instance = new MaterialDAO();
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
		public IEnumerable<MaterialDto> GetMaterials()
		{
			//var dest = mapper.Map<Source, Dest>(new Source());
			var saleManagementContext = new sales_managementContext();
			return saleManagementContext.Materials.ProjectTo<MaterialDto>(GetMappingConfig().ConfigurationProvider).ToList();
		}
		public (bool result, string reason) AddMaterial(MaterialDto materialDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var employee = GetMappingConfig().Map<Material>(materialDto);
				saleManagementContext.Materials.Add(employee);
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
		public (bool result, string reason) UpdateMaterial(MaterialDto materialDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var employee = GetMappingConfig().Map<Material>(materialDto);
				saleManagementContext.Materials.Update(employee);
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
		public (bool result, string reason) RemoveMaterial(MaterialDto materialDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var employee = GetMappingConfig().Map<Material>(materialDto);
				saleManagementContext.Materials.Remove(employee);
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
