using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
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
	public partial class frmMaterialUpdateOrCreate : Form
	{
		private bool _isCreateForm;
		private readonly IMaterialRepository _materialRepository;
		private MaterialDto _material;
		private readonly Action _action;
		public frmMaterialUpdateOrCreate(IMaterialRepository materialRepository, MaterialDto material, bool isCreateForm, Action action)
		{
			InitializeComponent();
			_materialRepository = materialRepository;
			_material = material;
			_action = action;
			_isCreateForm = isCreateForm;
		}
		private MaterialDto GetMaterialFromTxt()
		{			
			MaterialDto _materialDto = new MaterialDto();
			_materialDto.MaterialId = _material.MaterialId;
			_materialDto.MaterialName = txtMaterialName.Text;
			return _materialDto;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMaterialName.Text.ToString()))
			{
				MessageBox.Show("You need to fill in all the fields");
				return;
			}
			(bool result, string reason) response;
			if (!_isCreateForm) 
				response = _materialRepository.Update(GetMaterialFromTxt());
			else response = _materialRepository.Add(GetMaterialFromTxt());
			MessageBox.Show(response.result ? _isCreateForm ? "Add success" : "Update success" : response.reason);
			this.Close();
		}
		private void LoadForm()
		{

			if (!_isCreateForm)
			{
				lblCreateOrUpdateEmployee.Text = "Update a material";
				txtMaterialName.Text = _material.MaterialName;
			}
		}
		private void onFrmLoad(object sender, EventArgs e)
		{
			LoadForm();
		}

		private void onFormClosed(object sender, FormClosedEventArgs e)
		{
			_action.Invoke();
		}
	}
}
