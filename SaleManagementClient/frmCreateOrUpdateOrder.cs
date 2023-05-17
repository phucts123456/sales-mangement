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
		private readonly IOrderRepository _orderRepository;
		private IEnumerable<EmployeeDto> _employees;
		private IEnumerable<CustomerDto> _customer;
		private bool _isCreateForm = true;
		private Action<sbyte> _action;
		public frmCreateOrUpdateOrder(IEmployeeRepository employeeRepository, ICustomerRepository customerRepository, IOrderRepository orderRepository, OrderDto orderDto, bool isCreateForm, Action<sbyte> action)
		{
			InitializeComponent();
			_employeeRepository = employeeRepository;
			_customerRepository = customerRepository;
			_orderDto = orderDto;
			_isCreateForm = isCreateForm;
			_orderRepository = orderRepository;
			_action = action;
		}

		private void onFrm_Load(object sender, EventArgs e)
		{
			if (!_isCreateForm)
			{
				lblOrderForm.Text = "Update an order";
				_customer = _customerRepository.GetAll();
				_employees = _employeeRepository.GetAll();
				txtOrderDate.Text = _orderDto.OrderDate.ToString("dd/MM/yyyy");
				cbCustomerName.DataSource = _customer;
				cbCustomerName.DisplayMember = "CustomerName";
				cbCustomerName.ValueMember = "CustomerId";
				cbCustomerName.SelectedIndex = cbCustomerName.FindStringExact(_customer.FirstOrDefault(c => c.CustomerId == _orderDto.CustomerId).CustomerName);
				txtAddress.Text = _orderDto.Customer.Address;
				txtPhoneNumber.Text = _orderDto.Customer.PhoneNumber;
				cbEmployeeName.DataSource = _employees;
				cbEmployeeName.DisplayMember = "EmployeeName";
				cbEmployeeName.ValueMember = "EmployeeId";
				cbEmployeeName.SelectedIndex = cbEmployeeName.FindStringExact(_employees.FirstOrDefault(e => e.EmployeeId == _orderDto.EmployeeId).EmployeeName);
				MessageBox.Show(cbEmployeeName.SelectedValue.ToString());
				MessageBox.Show(cbCustomerName.SelectedValue.ToString());
			}
			else
			{
				_customer = _customerRepository.GetAll();
				_employees = _employeeRepository.GetAll();
				cbCustomerName.DataSource = _customer;
				cbCustomerName.DisplayMember = "CustomerName";
				cbCustomerName.ValueMember = "CustomerId";
				cbEmployeeName.DataSource = _employees;
				cbEmployeeName.DisplayMember = "EmployeeName";
				cbEmployeeName.ValueMember = "EmployeeId";
			}
		}
		private OrderDto GetOrderFromTxt()
		{
			OrderDto orderObj = new OrderDto();
			orderObj.OrderId = _orderDto != null ? _orderDto.OrderId : default(sbyte);
			orderObj.EmployeeId = sbyte.Parse(cbEmployeeName.SelectedValue.ToString()!);
			orderObj.OrderDate = DateTime.Parse(txtOrderDate.Text.ToString());
			orderObj.CustomerId = sbyte.Parse(cbCustomerName.SelectedValue.ToString()!);
			orderObj.Total = orderObj.Total;
			return orderObj;
		}

		private void customerName_Changed(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cbCustomerName.SelectedValue.ToString()) && !string.IsNullOrEmpty(txtAddress.Text))
			{
				MessageBox.Show(cbCustomerName.SelectedValue.ToString());
				CustomerDto customer = _customerRepository.GetCustomerById(sbyte.Parse(cbCustomerName.SelectedValue.ToString()!));
				txtAddress.Text = customer.Address;
				txtPhoneNumber.Text = customer.PhoneNumber;
			}			
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtOrderDate.Text.ToString()) || string.IsNullOrEmpty(cbCustomerName.Text.ToString()) || string.IsNullOrEmpty(cbEmployeeName.Text.ToString()))
			{
				MessageBox.Show("You need to fill in all the fields");
				return;
			}
			(bool result, string reason) response;

			if (!_isCreateForm) response = _orderRepository.Update(GetOrderFromTxt());
			else response = _orderRepository.Add(GetOrderFromTxt());
			MessageBox.Show(response.result ? _isCreateForm ? "Add success" : "Update success" : response.reason);
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frm_Closed(object sender, FormClosedEventArgs e)
		{
			if(_orderDto != null)
				_action.Invoke(_orderDto.OrderId);
			else
				_action.Invoke(default(sbyte));
		}
	}
}
