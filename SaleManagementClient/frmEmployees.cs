using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
using SaleManagementDAL.Repository.Abstraction;

namespace SaleManagementClient
{
	public partial class frmEmployees : Form
	{
		private delegate void DelegateWithMatchingSignature();

		private readonly IEmployeeRepository _employeeRepository;
		private IEnumerable<EmployeeDto> _employeeList;
		public frmEmployees(IEmployeeRepository employeeRepository)
		{
			InitializeComponent();
			_employeeRepository = employeeRepository;
		}
		private void LoadDataGridView()
		{
			_employeeList = _employeeRepository.GetAll();
			dgvEmlpoyees.DataSource = _employeeList;
			dgvEmlpoyees.Columns[0].HeaderText = "EmployeeID";
			dgvEmlpoyees.Columns[1].HeaderText = "EmployeeName";
			dgvEmlpoyees.Columns[2].HeaderText = "Sex";
			dgvEmlpoyees.Columns[3].HeaderText = "Address";
			dgvEmlpoyees.Columns[4].HeaderText = "PhoneNumber";
			dgvEmlpoyees.Columns[5].HeaderText = "DateOfBirth";
			dgvEmlpoyees.Columns[0].Width = 100;
			dgvEmlpoyees.Columns[1].Width = 100;
			dgvEmlpoyees.Columns[2].Width = 100;
			dgvEmlpoyees.Columns[3].Width = 100;
			dgvEmlpoyees.Columns[4].Width = 150;
			dgvEmlpoyees.Columns[5].Width = 200;
			dgvEmlpoyees.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
			dgvEmlpoyees.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
		}

		private void onFrmMainLoad(object sender, EventArgs e)
		{
			txtEmployeeID.Enabled = false;
			LoadDataGridView();
		}

		private void onDgvClick(object sender, EventArgs e)
		{
			if (btnReload.Enabled == false)
			{
				MessageBox.Show("AddingMode", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtEmployeeID.Focus();
				return;
			}
			if (_employeeList.Count() == 0) //Nếu không có dữ liệu
			{
				MessageBox.Show("No data on the table", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			DateTime aDate = DateTime.Parse(dgvEmlpoyees.CurrentRow.Cells["DateOfBirth"].Value.ToString()!);
			txtEmployeeName.Text = dgvEmlpoyees.CurrentRow.Cells["EmployeeName"].Value.ToString();
			txtAddress.Text = dgvEmlpoyees.CurrentRow.Cells["Address"].Value.ToString();
			txtDateOfBirth.Text = aDate.ToString("MM/dd/yyyy");
			txtPhoneNumber.Text = dgvEmlpoyees.CurrentRow.Cells["PhoneNumber"].Value.ToString();
			txtEmployeeID.Text = dgvEmlpoyees.CurrentRow.Cells["EmployeeID"].Value.ToString();
			if (dgvEmlpoyees.CurrentRow.Cells["Sex"].Value.ToString()!.ToLower().Equals("male"))
			{
				cbMale.Checked = true;
			}
			else
			{
				cbMale.Checked = false;
			}
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
		}
		private void ClearTextBox()
		{
			txtEmployeeName.Text = "";
			txtAddress.Text = "";
			txtDateOfBirth.Text = "";
			txtPhoneNumber.Text = "";
			txtEmployeeID.Text = "";
			cbFemale.Checked = false;
			cbMale.Checked = false;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmEmployeeUpdateOrCreate _frmEmployeeUpdateOrCreate = new frmEmployeeUpdateOrCreate(_employeeRepository,null ,true,LoadDataGridView);
			_frmEmployeeUpdateOrCreate.ShowDialog();
		}
		private EmployeeDto GetSelectedEmployeeFromGdv()
		{
			DateTime dateOfBirth;
			sbyte employeeId;
			EmployeeDto employeeDto = new EmployeeDto();
			if (dgvEmlpoyees.SelectedRows != null)
			{
				employeeDto.EmployeeName = string.IsNullOrEmpty(dgvEmlpoyees.CurrentRow.Cells["EmployeeName"].Value.ToString()) ? "" : dgvEmlpoyees.CurrentRow.Cells["EmployeeName"].Value.ToString()!;
				employeeDto.Address = string.IsNullOrEmpty(dgvEmlpoyees.CurrentRow.Cells["Address"].Value.ToString()) ? "" : dgvEmlpoyees.CurrentRow.Cells["Address"].Value.ToString()!;
				if (DateTime.TryParse(dgvEmlpoyees.CurrentRow.Cells["DateOfBirth"].Value.ToString(), out dateOfBirth)) employeeDto.DateOfBirth = dateOfBirth;
				employeeDto.PhoneNumber = string.IsNullOrEmpty(dgvEmlpoyees.CurrentRow.Cells["PhoneNumber"].Value.ToString()) ? "" : dgvEmlpoyees.CurrentRow.Cells["PhoneNumber"].Value.ToString()!;
				if (sbyte.TryParse(dgvEmlpoyees.CurrentRow.Cells["EmployeeID"].Value.ToString(), out employeeId)) employeeDto.EmployeeId = employeeId;
				employeeDto.Sex = string.IsNullOrEmpty(dgvEmlpoyees.CurrentRow.Cells["Sex"].Value.ToString()) ? "" : dgvEmlpoyees.CurrentRow.Cells["Sex"].Value.ToString()!;
			}
			return employeeDto;
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{	
			frmEmployeeUpdateOrCreate _frmEmployeeUpdateOrCreate = new frmEmployeeUpdateOrCreate(_employeeRepository, GetSelectedEmployeeFromGdv(), false, LoadDataGridView);
			_frmEmployeeUpdateOrCreate.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var mbResult = MessageBox.Show("Do you want to remove this employee","Please confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (mbResult == DialogResult.Yes) 
			{
				(bool result, string reason) response  = _employeeRepository.Remove(GetSelectedEmployeeFromGdv());
				MessageBox.Show(response.result ? "Remove success" : response.reason);
				LoadDataGridView();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			LoadDataGridView();
		}
	}
}
