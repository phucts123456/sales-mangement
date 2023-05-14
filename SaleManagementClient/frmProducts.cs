using SaleManagementDAL.Dtos;
using SaleManagementDAL.Repository;
using SaleManagementDAL.Repository.Abstraction;
using SaleManagementDAL.Serivces.Photo.Interfaces;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace SaleManagementClient
{
	public partial class frmProducts : Form
	{
		private readonly IProductRepository _productRepository;
		private readonly IMaterialRepository _materialRepository;
		private IEnumerable<ProductDto> _products;
		private IEnumerable<MaterialDto> _materials;
		private readonly IPhotoAccessor _photoAccessor;
		public frmProducts(IProductRepository productRepository, IMaterialRepository materialRepository, IPhotoAccessor photoAccessor)
		{
			InitializeComponent();
			_productRepository = productRepository;
			_materialRepository = materialRepository;
			_photoAccessor = photoAccessor;
		}

		private void onFrmLoad(object sender, EventArgs e)
		{
			LoadDataGridView();
		}

		private void LoadDataGridView()
		{
			_products = _productRepository.GetAll();
			dgvProducts.DataSource = _products;
			_materials = _materialRepository.GetAll();
			cboMaterialId.DataSource = _materials;
			cboMaterialId.DisplayMember = "MaterialName";
			cboMaterialId.ValueMember = "MaterialId";
			dgvProducts.Columns[0].HeaderText = "ProductId";	
			dgvProducts.Columns[1].HeaderText = "ProductName";	
			dgvProducts.Columns[2].HeaderText = "MaterialId";	
			dgvProducts.Columns[3].HeaderText = "Quantity";	
			dgvProducts.Columns[4].HeaderText = "CostOfGood";	
			dgvProducts.Columns[5].HeaderText = "RetailPrice";	
			dgvProducts.Columns[6].HeaderText = "Image";	
			dgvProducts.Columns[7].HeaderText = "Note";	
			dgvProducts.Columns[0].Width = 100;
			dgvProducts.Columns[1].Width = 100;
			dgvProducts.Columns[2].Width = 100;
			dgvProducts.Columns[3].Width = 100;
			dgvProducts.Columns[4].Width = 100;
			dgvProducts.Columns[5].Width = 100;
			dgvProducts.Columns[6].Width = 100;
			dgvProducts.Columns[7].Width = 100;
			dgvProducts.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
			dgvProducts.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
		}

		private void onDgv_Click(object sender, EventArgs e)
		{
			
			if (btnReload.Enabled == false)
			{
				MessageBox.Show("AddingMode", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtProductId.Focus();
				return;
			}
			if (_products.Count() == 0) //Nếu không có dữ liệu
			{
				MessageBox.Show("No data on the table", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			txtProductId.Text = dgvProducts.CurrentRow.Cells["ProductId"].Value.ToString();
			txtProductName.Text = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
			txtQuantity.Text = dgvProducts.CurrentRow.Cells["Quantity"].Value.ToString();
			txtCostOfGood.Text = dgvProducts.CurrentRow.Cells["CostOfGood"].Value.ToString();
			txtRetailPrice.Text = dgvProducts.CurrentRow.Cells["RetailPrice"].Value.ToString();
			txtImage.Text = dgvProducts.CurrentRow.Cells["Image"].Value.ToString();
			txtNote.Text = string.IsNullOrEmpty(dgvProducts.CurrentRow.Cells["Note"].Value.ToString()) ? "" : dgvProducts.CurrentRow.Cells["Note"].Value.ToString();
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
			AddBindingToCbo();
			BindImageToImageBox();
		}
		private void AddBindingToCbo()
		{
			cboMaterialId.SelectedIndex = cboMaterialId.FindStringExact(_materials.FirstOrDefault(x => x.MaterialId == sbyte.Parse(dgvProducts.CurrentRow.Cells["MaterialId"].Value.ToString()!))!.MaterialName);
		}
		private void BindImageToImageBox()
		{
			//slow
			/*var request = WebRequest.Create(dgvProducts.CurrentRow.Cells["Image"].Value.ToString());
			using (var response = request.GetResponse())
			using (var stream = response.GetResponseStream())
			{
				picImage.Image = Bitmap.FromStream(stream);
				picImage.SizeMode = PictureBoxSizeMode.StretchImage;
				
			}*/
			//faster
			picImage.ImageLocation = dgvProducts.CurrentRow.Cells["Image"].Value.ToString();
			picImage.SizeMode = PictureBoxSizeMode.StretchImage;
			picImage.Load();
		}

		private void IndexChanged(object sender, EventArgs e)
		{
			//MaterialDto selectedMaterial = (MaterialDto)cboMaterialId.SelectedValue;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			frmUpdateOrCreateProduct _frmUpdateOrCreateProduct = new frmUpdateOrCreateProduct(_productRepository, LoadDataGridView, null,true, _photoAccessor, _materialRepository);
			_frmUpdateOrCreateProduct.ShowDialog();
		}
		private ProductDto GetSelectedProductFromGdv()
		{
			sbyte productId;
			sbyte materialId;
			decimal costOfGood;
			decimal retailPrice;
			int quantity;
			ProductDto productDto = new ProductDto();
			if (dgvProducts.SelectedRows != null)
			{
				productDto.ProductName = string.IsNullOrEmpty(dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString()) ? "" : dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString()!;
				if(decimal.TryParse(dgvProducts.CurrentRow.Cells["CostOfGood"].Value.ToString(),out costOfGood)) productDto.CostOfGood = costOfGood ;
				if (decimal.TryParse(dgvProducts.CurrentRow.Cells["RetailPrice"].Value.ToString(), out retailPrice)) productDto.RetailPrice = retailPrice;
				productDto.Note = string.IsNullOrEmpty(dgvProducts.CurrentRow.Cells["Note"].Value.ToString()) ? "" : dgvProducts.CurrentRow.Cells["Note"].Value.ToString()!;
				productDto.Image = string.IsNullOrEmpty(dgvProducts.CurrentRow.Cells["Image"].Value.ToString()) ? "" : dgvProducts.CurrentRow.Cells["Image"].Value.ToString()!;
				if (int.TryParse(dgvProducts.CurrentRow.Cells["Quantity"].Value.ToString(), out quantity)) productDto.Quantity = quantity;
				if (sbyte.TryParse(dgvProducts.CurrentRow.Cells["ProductId"].Value.ToString(), out productId)) productDto.ProductId = productId;
				productDto.MaterialId = sbyte.Parse(cboMaterialId.SelectedValue.ToString()!);
			}
			return productDto;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			
			frmUpdateOrCreateProduct _frmUpdateOrCreateProduct = new frmUpdateOrCreateProduct(_productRepository, LoadDataGridView, GetSelectedProductFromGdv(), false, _photoAccessor, _materialRepository);
			_frmUpdateOrCreateProduct.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var mbResult = MessageBox.Show("Do you want to remove this employee", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (mbResult == DialogResult.Yes)
			{
				(bool result, string reason) response = _productRepository.Remove(GetSelectedProductFromGdv());
				MessageBox.Show(response.result ? "Remove success" : response.reason);
				LoadDataGridView();
			}
		}
	}
}
