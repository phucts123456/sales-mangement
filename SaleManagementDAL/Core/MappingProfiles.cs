using AutoMapper;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;


namespace SaleManagementDAL.Core
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<Employee,EmployeeDto>().ReverseMap();
			CreateMap<Material,MaterialDto>().ReverseMap();
			CreateMap<Customer,CustomerDto>().ReverseMap();
			CreateMap<Product,ProductDto>().ReverseMap();
			CreateMap<Order,OrderDto>().ReverseMap();
			CreateMap<OrderDetail,OrderDetailDto>().ReverseMap();
		}
	}
}
