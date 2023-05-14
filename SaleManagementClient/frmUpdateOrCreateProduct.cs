using Microsoft.VisualBasic.ApplicationServices;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
using SaleManagementDAL.Repository;
using SaleManagementDAL.Repository.Abstraction;
using SaleManagementDAL.Serivces.Photo.Interfaces;

namespace SaleManagementClient
{
	public partial class frmUpdateOrCreateProduct : Form
	{
		private bool _isCreateForm;
		private readonly IProductRepository _productRepository;
		private ProductDto _product;
		private readonly Action _action;
		private IMaterialRepository _materialRepository;
		private readonly IPhotoAccessor _photoAccessor;
		private  IEnumerable<MaterialDto> _materials;
		public frmUpdateOrCreateProduct(IProductRepository productRepository, Action action, ProductDto product, bool isCreateForm, IPhotoAccessor photoAccessor, IMaterialRepository materialRepository)
		{
			InitializeComponent();
			_productRepository = productRepository;
			_action = action;
			_product = product;
			_isCreateForm = isCreateForm;			
			_photoAccessor = photoAccessor;
			_materialRepository = materialRepository;
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
			if (opnfd.ShowDialog() == DialogResult.OK)
			{
				picImage.SizeMode = PictureBoxSizeMode.StretchImage;
				/*picImage.Image = new Bitmap(opnfd.FileName);
				txtImage.Text = opnfd.FileName;*/
				string workingDirectory = Environment.CurrentDirectory;
				Console.WriteLine();
				picImage.Image = new Bitmap(Directory.GetParent(workingDirectory).Parent.Parent.FullName+@"/Resources/loading.gif");
				var uploadPhotoResult = _photoAccessor.AddPhotoSyn(opnfd.FileName);
				if (uploadPhotoResult != null)
				{
					txtImage.Text = uploadPhotoResult.Url;
					picImage.ImageLocation = uploadPhotoResult.Url;
					picImage.Load();
				}
				else
				{
					MessageBox.Show("Upload photo failed");
				}
			}
		}
		private ProductDto GetProductFromTxt()
		{
			ProductDto productDto = new ProductDto()
			{
				CostOfGood = decimal.Parse(txtCostOfGood.Text.ToString()),
				RetailPrice = decimal.Parse(txtRetailPrice.Text.ToString()),
				Image = txtImage.Text,
				MaterialId = sbyte.Parse(cbMaterialId.SelectedValue.ToString()!),
				Note = string.IsNullOrEmpty(txtNote.Text) ? string.Empty : txtNote.Text,
				ProductId = !_isCreateForm ? _product.ProductId : default(sbyte),
				ProductName = txtProductName.Text,
				Quantity = int.Parse(txtQuantity.Text.ToString()),
			};
			
			return productDto;
		}
		private void AddBindingToCbo()
		{
			_materials = _materialRepository.GetAll();
			cbMaterialId.DataSource = _materials;
			cbMaterialId.DisplayMember = "MaterialName";
			cbMaterialId.ValueMember = "MaterialId";
		}
		private void onFrm_Load(object sender, EventArgs e)
		{
			AddBindingToCbo();
			LoadForm();
			if(!_isCreateForm) BindImageToImageBox();
		}
		private void LoadForm()
		{
			if (!_isCreateForm)
			{
				lblCreateOrUpdateProduct.Text = "Update a product";
				txtImage.Text = _product.Image;
				txtCostOfGood.Text = _product.CostOfGood.ToString();
				txtRetailPrice.Text = _product.RetailPrice.ToString();
				txtProductName.Text = _product.ProductName;
				txtNote.Text = _product.Note;
				txtQuantity.Text = _product.Quantity.ToString();
				cbMaterialId.SelectedIndex = cbMaterialId.FindStringExact(_materials.FirstOrDefault(x => x.MaterialId == sbyte.Parse(_product.MaterialId.ToString()))!.MaterialName);
			}
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
			picImage.ImageLocation = _product.Image;
			picImage.SizeMode = PictureBoxSizeMode.StretchImage;
			picImage.Load();
		}
		private void onForm_Closed(object sender, FormClosedEventArgs e)
		{
			_action.Invoke();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCostOfGood.Text.ToString()) || string.IsNullOrEmpty(txtImage.Text.ToString())
			|| string.IsNullOrEmpty(txtQuantity.Text.ToString()) || string.IsNullOrEmpty(txtProductName.Text.ToString())
			|| string.IsNullOrEmpty(txtRetailPrice.Text.ToString()))
			{
				MessageBox.Show("You need to fill in all the fields");
				return;
			}
			(bool result, string reason) response;
			if (!_isCreateForm) response = _productRepository.Update(GetProductFromTxt());
			else response = _productRepository.Add(GetProductFromTxt());
			MessageBox.Show(response.result ? _isCreateForm ? "Add success" : "Update success" : response.reason);
			this.Close();
		}
	}
}
