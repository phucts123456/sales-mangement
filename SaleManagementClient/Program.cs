using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SaleManagementDAL.Models;
using System.Xml.Linq;
using System.Configuration;
using SaleManagementDAL.Repository.Abstraction;
using SaleManagementDAL.Repository;
using Microsoft.Extensions.Configuration;
using SaleManagementDAL.Serivces.Photo;
using SaleManagementDAL.Serivces.Photo.Interfaces;

namespace SaleManagementClient
{
	internal static class Program
	{
		private static readonly IConfiguration Configuration = null!;
		private static readonly IHost _host
		 = Host.CreateDefaultBuilder()			
				.ConfigureServices(services =>
				{
					var builder = new ConfigurationBuilder()
					.SetBasePath(Environment.CurrentDirectory)
					.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
					.AddJsonFile($"appsettings.json", optional: true)//To specify environment
					.AddEnvironmentVariables();//You can add if you need to read environment variables.
											   //Build the configuration
					IConfiguration Configuration = builder.Build();
					//string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; //get from app.config file 
					services.AddDbContext<sales_managementContext>(opt =>
					{
						opt.UseMySQL(Configuration.GetConnectionString("DefaultConnection"));
					});
					services.AddSingleton<frmMain>();
					services.AddSingleton<frmEmployees>();
					services.AddSingleton<frmCustomers>();
					services.AddSingleton<frmEmployeeUpdateOrCreate>();
					services.AddSingleton<frmMaterials>();
					services.AddSingleton<frmProducts>();
					services.AddSingleton<frmOrders>();
					services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
					services.AddSingleton<IProductRepository, ProductRepository>();
					services.AddTransient<IPhotoAccessor, PhotoAccessor>();
					services.AddSingleton<IMaterialRepository, MaterialRepository>();
					services.AddSingleton<ICustomerRepository, CustomerRepository>();
					services.AddSingleton<IOrderRepository, OrderRepository>();
					services.AddSingleton<IOrderDetailRepository, OrderDetailRepository>();
					services.Configure<CloudinarySettings>(Configuration.GetSection("Cloudinary"));
				})
				.Build();
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			_host.Start();
			ApplicationConfiguration.Initialize();
			var frmMain = _host.Services.GetRequiredService<frmMain>();

			//Lệnh chạy gốc là: Application.Run(new Form1);
			//Đã được thay thế bằng lệnh sử dụng service khai báo trong host
			Application.Run(frmMain);

			//Khi form chính (form1) bị đóng <==> chương trình kết thúc ấy
			//thì dừng host
			_host.StopAsync().GetAwaiter().GetResult();

			//và giải phóng tài nguyên host đã sử dụng.
			_host.Dispose();
		}
	}
}