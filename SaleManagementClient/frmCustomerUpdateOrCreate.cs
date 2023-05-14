using SaleManagementDAL.Dtos;
using SaleManagementDAL.Repository.Abstraction;

namespace SaleManagementClient
{
	public partial class frmCustomerUpdateOrCreate : Form
	{
		private bool _isCreateForm;
		private readonly ICustomerRepository _customerRepository;
		private CustomerDto _customer;
		private readonly Action _action;
		public frmCustomerUpdateOrCreate(ICustomerRepository customerRepository, CustomerDto customer, bool isCreateForm , Action action)
		{
			InitializeComponent();
			_isCreateForm = isCreateForm;
			_customerRepository = customerRepository;
			_action = action;
			_customer = customer;
		}
		private void LoadForm()
		{
			if (!_isCreateForm)
			{
				lblCreateOrUpdateCustomer.Text = "Update a customer";
				txtAddress.Text = _customer.Address;
				txtPhoneNumber.Text = _customer.PhoneNumber;
				txtCustomerName.Text = _customer.CustomerName;		
			}
		}
		private void onFrmLoad(object sender, EventArgs e)
		{
			LoadForm();
		}

		private CustomerDto GetCustomerFromTxt()
		{
			CustomerDto customerDto = new CustomerDto();
			customerDto.CustomerId = _customer.CustomerId;
			customerDto.Address = txtAddress.Text;
			customerDto.PhoneNumber = txtPhoneNumber.Text;
			customerDto.CustomerName = txtCustomerName.Text;
			return customerDto;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCustomerName.Text.ToString()) || string.IsNullOrEmpty(txtAddress.Text.ToString())
			|| string.IsNullOrEmpty(txtPhoneNumber.Text.ToString()))
			{
				MessageBox.Show("You need to fill in all the fields");
				return;
			}
			(bool result, string reason) response;
			if (!_isCreateForm) response = _customerRepository.Update(GetCustomerFromTxt());
			else response = _customerRepository.Add(GetCustomerFromTxt());
			MessageBox.Show(response.result ? _isCreateForm ? "Add success" : "Update success" : response.reason);
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void onFrmClose(object sender, FormClosedEventArgs e)
		{
			_action.Invoke();
		}
	}
}
