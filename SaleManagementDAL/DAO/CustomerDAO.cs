using AutoMapper;
using AutoMapper.QueryableExtensions;
using SaleManagementDAL.Core;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;

namespace SaleManagementDAL.DAO
{
	public class CustomerDAO
	{
		private static CustomerDAO instance = null;
		private static readonly object instanceLock =  new object();

		public CustomerDAO()
		{
		}
		public static CustomerDAO Instance 
		{ 
			get 
			{ 
				lock(instanceLock)
				{
					if(instance == null)
					{
						instance = new CustomerDAO();
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
		public IEnumerable<CustomerDto> GetCustomers()
		{
			//var dest = mapper.Map<Source, Dest>(new Source());
			var saleManagementContext = new sales_managementContext();
			return saleManagementContext.Customers.ProjectTo<CustomerDto>(GetMappingConfig().ConfigurationProvider).ToList();
		}
		public (bool result, string reason) AddCustomer(CustomerDto customer)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var Customer = GetMappingConfig().Map<Customer>(customer);
				saleManagementContext.Customers.Add(Customer);
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
		public (bool result, string reason) UpdateCustomer(CustomerDto customer)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var Customer = GetMappingConfig().Map<Customer>(customer);
				saleManagementContext.Customers.Update(Customer);
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
		public (bool result, string reason) RemoveCustomer(CustomerDto customer)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var Customer = GetMappingConfig().Map<Customer>(customer);
				saleManagementContext.Customers.Remove(Customer);
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
