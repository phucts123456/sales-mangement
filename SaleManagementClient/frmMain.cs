using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace SaleManagementClient
{
	public partial class frmMain : Form
	{
		private readonly frmEmployees _frmEmployees;
		private readonly frmMaterials _frmMaterials;
		private readonly frmCustomers _frmCustomers;
		private readonly frmProducts _frmProducts;
		public frmMain(frmEmployees frmEmployees, frmMaterials frmMaterials, frmCustomers frmCustomers, frmProducts frmProducts)
		{
			//BackgroundImage = Properties.Resources.blueBackgroud;
			InitializeComponent();
			Console.WriteLine(Environment.CurrentDirectory + @"/Resources/blueBackground.jpg");
			/*pnlMain.BackgroundImage =  Image.FromFile
		   (Environment.CurrentDirectory + @"../../../../Resources/blueBackgroud.jpg");*/
			pnlMain.BackColor = Color.AliceBlue;
			_frmEmployees = frmEmployees;
			_frmMaterials = frmMaterials;
			_frmCustomers = frmCustomers;
			_frmProducts = frmProducts;
		}

		private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_frmEmployees.ShowDialog(); 
		}

		private void materialsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_frmMaterials.ShowDialog();
		}

		private void customersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_frmCustomers.ShowDialog();
		}

		private void productsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_frmProducts.ShowDialog();
		}
	}
}