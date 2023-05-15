using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SaleManagementDAL.Core;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;


namespace SaleManagementDAL.DAO
{
	public class OrderDAO
	{
		private static OrderDAO instance = null;
		private readonly static object instanceLock = new object();
		public static OrderDAO Instance
		{
			get
			{
				lock(instanceLock)
				{
					if(instance == null)
					{
						instance = new OrderDAO();
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
		public IEnumerable<OrderDto> GetOrders()
		{
			//var dest = mapper.Map<Source, Dest>(new Source());
			var saleManagementContext = new sales_managementContext();
			return saleManagementContext.Orders.Include(o => o.Employee).Include(o => o.Customer).ProjectTo<OrderDto>(GetMappingConfig().ConfigurationProvider).ToList();
		}
		public (bool result, string reason) AddOrder(OrderDto orderDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var order = GetMappingConfig().Map<Order>(orderDto);
				saleManagementContext.Orders.Add(order);
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
		public (bool result, string reason) UpdateOrder(OrderDto orderDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var order = GetMappingConfig().Map<Order>(orderDto);
				saleManagementContext.Orders.Update(order);
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
		public (bool result, string reason) RemoveOrder(OrderDto orderDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var order = GetMappingConfig().Map<Order>(orderDto);
				if (saleManagementContext.OrderDetails.Any(x => x.OrderId == orderDto.OrderId))
					return (false, "Delete failed. This order already have had at least 1 order detail.");
				saleManagementContext.Orders.Remove(order);
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
