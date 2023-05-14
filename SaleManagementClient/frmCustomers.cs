using SaleManagementDAL.Dtos;
using SaleManagementDAL.Repository;
using SaleManagementDAL.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementClient
{
	public partial class frmCustomers : Form
	{
		private readonly ICustomerRepository _customerRepository;
		private IEnumerable<CustomerDto> _customerList;

		public frmCustomers(ICustomerRepository customerRepository)
		{
			InitializeComponent();
			_customerRepository = customerRepository;
		}
		private void LoadDataGridView()
		{
			_customerList = _customerRepository.GetAll();
			dgvCustomers.DataSource = _customerList;
			dgvCustomers.Columns[0].HeaderText = "CustomerID";
			dgvCustomers.Columns[1].HeaderText = "CustomerName";
			dgvCustomers.Columns[2].HeaderText = "Address";
			dgvCustomers.Columns[3].HeaderText = "PhoneNumber";
			dgvCustomers.Columns[0].Width = 100;
			dgvCustomers.Columns[1].Width = 200;
			dgvCustomers.Columns[2].Width = 200;
			dgvCustomers.Columns[3].Width = 200;
			dgvCustomers.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
			dgvCustomers.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
		}
		private void onFrmLoad(object sender, EventArgs e)
		{
			txtCustomerId.Enabled= false;
			LoadDataGridView();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			LoadDataGridView();
		}



		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmCustomerUpdateOrCreate _frmEmployeeUpdateOrCreate = new frmCustomerUpdateOrCreate(_customerRepository, null, true, LoadDataGridView);
			_frmEmployeeUpdateOrCreate.ShowDialog();
		}
		private CustomerDto GetSelectedEmployeeFromGdv()
		{
			sbyte customerId;
			CustomerDto customerDto = new CustomerDto();
			if (dgvCustomers.SelectedRows != null)
			{
				customerDto.CustomerName = string.IsNullOrEmpty(dgvCustomers.CurrentRow.Cells["CustomerName"].Value.ToString()) ? "" : dgvCustomers.CurrentRow.Cells["CustomerName"].Value.ToString()!;
				customerDto.Address = string.IsNullOrEmpty(dgvCustomers.CurrentRow.Cells["Address"].Value.ToString()) ? "" : dgvCustomers.CurrentRow.Cells["Address"].Value.ToString()!;
				customerDto.PhoneNumber = string.IsNullOrEmpty(dgvCustomers.CurrentRow.Cells["PhoneNumber"].Value.ToString()) ? "" : dgvCustomers.CurrentRow.Cells["PhoneNumber"].Value.ToString()!;
				if (sbyte.TryParse(dgvCustomers.CurrentRow.Cells["CustomerID"].Value.ToString(), out customerId)) customerDto.CustomerId = customerId;
			}
			return customerDto;
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			var mbResult = MessageBox.Show("Do you want to remove this employee", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (mbResult == DialogResult.Yes)
			{
				(bool result, string reason) response = _customerRepository.Remove(GetSelectedEmployeeFromGdv());
				MessageBox.Show(response.result ? "Remove success" : response.reason);
				LoadDataGridView();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			frmCustomerUpdateOrCreate _frmEmployeeUpdateOrCreate = new frmCustomerUpdateOrCreate(_customerRepository, GetSelectedCustomerFromGdv(), false, LoadDataGridView);
			_frmEmployeeUpdateOrCreate.ShowDialog();
		}

		private CustomerDto GetSelectedCustomerFromGdv()
		{
			sbyte customerId;
			CustomerDto customerDto = new CustomerDto();
			if (dgvCustomers.SelectedRows != null)
			{
				customerDto.CustomerName = string.IsNullOrEmpty(dgvCustomers.CurrentRow.Cells["CustomerName"].Value.ToString()) ? "" : dgvCustomers.CurrentRow.Cells["CustomerName"].Value.ToString()!;
				customerDto.Address = string.IsNullOrEmpty(dgvCustomers.CurrentRow.Cells["Address"].Value.ToString()) ? "" : dgvCustomers.CurrentRow.Cells["Address"].Value.ToString()!;
				customerDto.PhoneNumber = string.IsNullOrEmpty(dgvCustomers.CurrentRow.Cells["PhoneNumber"].Value.ToString()) ? "" : dgvCustomers.CurrentRow.Cells["PhoneNumber"].Value.ToString()!;
				if (sbyte.TryParse(dgvCustomers.CurrentRow.Cells["CustomerID"].Value.ToString(), out customerId)) customerDto.CustomerId = customerId;
			}
			return customerDto;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void onDgvClick(object sender, EventArgs e)
		{
			if (btnReload.Enabled == false)
			{
				MessageBox.Show("AddingMode", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtCustomerId.Focus();
				return;
			}
			if (_customerList.Count() == 0) //Nếu không có dữ liệu
			{
				MessageBox.Show("No data on the table", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			txtCustomerId.Text = dgvCustomers.CurrentRow.Cells["CustomerId"].Value.ToString();
			txtAddress.Text = dgvCustomers.CurrentRow.Cells["Address"].Value.ToString();
			txtCustomerName.Text = dgvCustomers.CurrentRow.Cells["CustomerName"].Value.ToString();
			txtPhoneNumber.Text = dgvCustomers.CurrentRow.Cells["PhoneNumber"].Value.ToString();
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
		}
	}
}
