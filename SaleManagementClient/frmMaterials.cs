using SaleManagementDAL.DAO;
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
	public partial class frmMaterials : Form
	{
		private readonly IMaterialRepository _materialRepository;
		private  IEnumerable<MaterialDto> _materialsList;
		public frmMaterials(IMaterialRepository materialRepository)
		{
			InitializeComponent();
			_materialRepository = materialRepository;
		}

		private void onFrmLoad(object sender, EventArgs e)
		{
			txtMaterialId.Enabled = false;
			LoadDataGridView();
		}
		private void LoadDataGridView()
		{
			_materialsList = _materialRepository.GetAll();
			dgvMaterials.DataSource = _materialsList;
			dgvMaterials.Columns[0].HeaderText = "MaterialID";
			dgvMaterials.Columns[1].HeaderText = "MaterialName";
			dgvMaterials.Columns[0].Width = 100;
			dgvMaterials.Columns[1].Width = 200;
			dgvMaterials.AllowUserToAddRows = false; //User can not directly add a row on dgv
			dgvMaterials.EditMode = DataGridViewEditMode.EditProgrammatically; //User can not directly edit a row on dgv
		}

		private void onDgvClick(object sender, EventArgs e)
		{
			if (btnSave.Enabled == false)
			{
				MessageBox.Show("AddingMode", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMaterialId.Focus();
				return;
			}
			if (_materialsList.Count() == 0) //Nếu không có dữ liệu
			{
				MessageBox.Show("No data on the table", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			txtMaterialName.Text = dgvMaterials.CurrentRow.Cells["MaterialName"].Value.ToString();
			txtMaterialId.Text = dgvMaterials.CurrentRow.Cells["MaterialID"].Value.ToString();
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
		}
		private MaterialDto GetSelectedMaterialFromGdv()
		{
			sbyte materialId;
			string materialName = dgvMaterials.CurrentRow.Cells["MaterialName"].Value.ToString()!;
			MaterialDto materialDto = new MaterialDto();
			if (dgvMaterials.SelectedRows != null)
			{
				if (sbyte.TryParse(dgvMaterials.CurrentRow.Cells["MaterialId"].Value.ToString(), out materialId)) materialDto.MaterialId = materialId;
				materialDto.MaterialName = string.IsNullOrEmpty(materialName) ? "" : materialName;	
			}
			return materialDto;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmMaterialUpdateOrCreate _frmMaterialUpdateOrCreate = new frmMaterialUpdateOrCreate(_materialRepository, null, true, LoadDataGridView);
			_frmMaterialUpdateOrCreate.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			frmMaterialUpdateOrCreate _frmEmployeeUpdateOrCreate = new frmMaterialUpdateOrCreate(_materialRepository, GetSelectedMaterialFromGdv(), false, LoadDataGridView);
			_frmEmployeeUpdateOrCreate.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var mbResult = MessageBox.Show("Do you want to remove this material", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (mbResult == DialogResult.Yes)
			{
				(bool result, string reason) response = _materialRepository.Remove(GetSelectedMaterialFromGdv());
				MessageBox.Show(response.result ? "Remove success" : response.reason);
				LoadDataGridView();
			}
		}

		private void onBtnReload_Click(object sender, EventArgs e)
		{
			LoadDataGridView();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
