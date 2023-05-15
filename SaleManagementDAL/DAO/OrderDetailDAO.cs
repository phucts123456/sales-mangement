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
	public class OrderDetailDAO
	{
		private static OrderDetailDAO instance = null;
		private readonly static object instanceLock = new object();
		public static OrderDetailDAO Instance
		{
			get
			{
				lock(instanceLock)
				{
					if (instance == null)
					{
						instance = new OrderDetailDAO();
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
		public IEnumerable<OrderDetailDto> GetOrderDetails(sbyte orderId)
		{
			//var dest = mapper.Map<Source, Dest>(new Source());
			var saleManagementContext = new sales_managementContext();
			return saleManagementContext.OrderDetails.Where(x => x.OrderId == orderId).ProjectTo<OrderDetailDto>(GetMappingConfig().ConfigurationProvider).ToList();
		}
		public (bool result, string reason) AddOrderDetail(OrderDetailDto orderDetailDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var orderDetail = GetMappingConfig().Map<Order>(orderDetailDto);
				saleManagementContext.Orders.Add(orderDetail);
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
		public (bool result, string reason) UpdateOrderDetail(OrderDetailDto orderDetailDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var orderDetail = GetMappingConfig().Map<Order>(orderDetailDto);
				saleManagementContext.Orders.Update(orderDetail);
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
		public (bool result, string reason) RemoveOrderDetail(OrderDetailDto orderDetailDto)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.AddProfile<MappingProfiles>();
				//cfg.CreateMap<Source, Dest>();
			});
			IMapper mapper = new Mapper(config);
			try
			{
				var saleManagementContext = new sales_managementContext();
				var orderDetail = GetMappingConfig().Map<Order>(orderDetailDto);
				saleManagementContext.Orders.Remove(orderDetail);
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
