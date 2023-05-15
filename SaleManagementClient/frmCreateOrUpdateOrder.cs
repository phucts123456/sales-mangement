using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
using SaleManagementDAL.Repository.Abstraction;

namespace SaleManagementClient
{
	public partial class frmCreateOrUpdateOrder : Form
	{
		private OrderDto _orderDto;
		private readonly ICustomerRepository _customerRepository;
		private readonly IEmployeeRepository _employeeRepository;
		private IEnumerable<EmployeeDto> _employees;
		private IEnumerable<CustomerDto> _customer;
		private bool _isCreateForm = true;
		public frmCreateOrUpdateOrder(IEmployeeRepository employeeRepository, ICustomerRepository customerRepository, OrderDto orderDto, bool isCreateForm)
		{
			InitializeComponent();
			_employeeRepository = employeeRepository;
			_customerRepository = customerRepository;
			_orderDto = orderDto;
			_isCreateForm = isCreateForm;
		}

		private void onFrm_Load(object sender, EventArgs e)
		{
			if (!_isCreateForm)
			{
				lblOrderForm.Text = "Update an order";
				_customer = _customerRepository.GetAll();
				_employees = _employeeRepository.GetAll();
				txtAddress.Text = _orderDto.Customer.Address;
				txtOrderDate.Text = _orderDto.OrderDate.ToString("dd/MM/yyyy");
				txtPhoneNumber.Text = _orderDto.Customer.PhoneNumber;
				cbCustomerName.DataSource = _customer;
				cbCustomerName.DisplayMember = "CustomerName";
				cbCustomerName.ValueMember = "CustomerId";
				cbCustomerName.SelectedIndex = cbCustomerName.FindStringExact(_customer.FirstOrDefault(c => c.CustomerId == _orderDto.CustomerId).CustomerName);
				cbEmployeeName.DataSource = _employees;
				cbEmployeeName.DisplayMember = "EmployeeName";
				cbEmployeeName.ValueMember = "EmployeeId";
				cbEmployeeName.SelectedIndex = cbEmployeeName.FindStringExact(_employees.FirstOrDefault(e => e.EmployeeId == _orderDto.EmployeeId).EmployeeName);
			}		
		}

	}
}
