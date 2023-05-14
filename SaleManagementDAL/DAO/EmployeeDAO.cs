
using AutoMapper;
using AutoMapper.QueryableExtensions;
using SaleManagementDAL.Core;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;

namespace SaleManagementDAL.DAO
{
	//thread-safe singleton
	//sealed for preventing others class inheriting
	public sealed class EmployeeDAO 
	{
		
		private static EmployeeDAO instance = null;
		private static readonly object instanceLock = new object();
		private EmployeeDAO() { }
		public static EmployeeDAO Instance 
		{ 
			get 
			{ 
				lock (instanceLock) 
				{ 
					if(instance == null) 
					{ 
						instance = new EmployeeDAO();
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
		public IEnumerable<EmployeeDto> GetEmployees()
		{
			//var dest = mapper.Map<Source, Dest>(new Source());
			var saleManagementContext = new sales_managementContext();
			return saleManagementContext.Employees.ProjectTo<EmployeeDto>(GetMappingConfig().ConfigurationProvider).ToList();
		}
		public (bool result,string reason) AddEmployee(EmployeeDto employeeDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var employee = GetMappingConfig().Map<Employee>(employeeDto);
				saleManagementContext.Employees.Add(employee);
				if (saleManagementContext.SaveChanges() > 0)
				{
					return (true, "");
				}
			}
			catch (Exception ex)
			{
				return (false , "Add failed. "+ ex.ToString());
			}
			return (false, "Add failed. Unknow exception.");	
		}
		public (bool result, string reason) UpdateEmployee(EmployeeDto employeeDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var employee = GetMappingConfig().Map<Employee>(employeeDto);
				saleManagementContext.Employees.Update(employee);
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
		public (bool result, string reason) RemoveEmployee(EmployeeDto employeeDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var employee = GetMappingConfig().Map<Employee>(employeeDto);
				saleManagementContext.Employees.Remove(employee);
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
