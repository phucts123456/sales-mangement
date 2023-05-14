using SaleManagementDAL.Dtos;
using SaleManagementDAL.Repository.Abstraction;

namespace SaleManagementClient
{
	public partial class frmEmployeeUpdateOrCreate : Form
	{
		private bool _isCreateForm;
		private readonly IEmployeeRepository _employeeRepository;
		private EmployeeDto _employee;
		private readonly Action _action;
		public frmEmployeeUpdateOrCreate(IEmployeeRepository employeeRepository, EmployeeDto employee = null, bool isCreateForm = true, Action action = null)
		{
			InitializeComponent();
			pnlParent.BackColor = Color.AliceBlue;
			_employee = employee;
			_isCreateForm = isCreateForm;
			_employeeRepository = employeeRepository;
			_action = action;
		}

		private void onFrmLoad(object sender, EventArgs e)
		{
			LoadForm();
		}
		private void LoadForm()
		{
			if (!_isCreateForm)
			{
				lblCreateOrUpdateEmployee.Text = "Update an employee";
				txtAddress.Text = _employee.Address;
				txtDateOfBirth.Text = _employee.DateOfBirth.ToString("MM/dd/yyyy");			
				txtPhoneNumber.Text = _employee.PhoneNumber;
				txtEmployeeName.Text = _employee.EmployeeName;
				if(_employee.Sex.ToLower().Equals("female")) 
					cbFemale.Checked = true;			
				else  
					cbMale.Checked = true; 
			}
		}
		private EmployeeDto GetEmployeeFromTxt()
		{
			EmployeeDto employeeObj = new EmployeeDto();
			employeeObj.EmployeeId = _employee.EmployeeId;
			employeeObj.Address = txtAddress.Text;
			employeeObj.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text.ToString());
			employeeObj.PhoneNumber = txtPhoneNumber.Text;
			employeeObj.EmployeeName = txtEmployeeName.Text;
			employeeObj.Sex = cbMale.Checked ? "Male" : "Female";
			return employeeObj;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtDateOfBirth.Text.ToString()) || string.IsNullOrEmpty(txtEmployeeName.Text.ToString()) || string.IsNullOrEmpty(txtAddress.Text.ToString())
				|| string.IsNullOrEmpty(txtPhoneNumber.Text.ToString()) || (!cbFemale.Checked  && !cbMale.Checked)) 
			{	
				MessageBox.Show("You need to fill in all the fields"); 
				return; 
			}
			(bool result, string reason) response;
			
			if (!_isCreateForm) response = _employeeRepository.Update(GetEmployeeFromTxt());
			else response =_employeeRepository.Add(GetEmployeeFromTxt());
			MessageBox.Show(response.result ? _isCreateForm ? "Add success" : "Update success" : response.reason);
			this.Close();
		}

		private void onFrmClosed(object sender, FormClosedEventArgs e)
		{
			MessageBox.Show("Success");
		}

		private void onClosed(object sender, FormClosedEventArgs e)
		{
			_action.Invoke();
		}
	}
}
