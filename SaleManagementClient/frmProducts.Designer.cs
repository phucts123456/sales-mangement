namespace SaleManagementClient
{
	partial class frmProducts
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblProductId = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblMaterialId = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblCostOfGood = new System.Windows.Forms.Label();
			this.lblRetailPrice = new System.Windows.Forms.Label();
			this.lblProductList = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtCostOfGood = new System.Windows.Forms.TextBox();
			this.txtRetailPrice = new System.Windows.Forms.TextBox();
			this.cboMaterialId = new System.Windows.Forms.ComboBox();
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.lblImage = new System.Windows.Forms.Label();
			this.txtImage = new System.Windows.Forms.TextBox();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.lblNote = new System.Windows.Forms.Label();
			this.picImage = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(11, 54);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(77, 20);
			this.lblProductId.TabIndex = 0;
			this.lblProductId.Text = "Product Id";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(11, 87);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(104, 20);
			this.lblProductName.TabIndex = 1;
			this.lblProductName.Text = "Product Name";
			// 
			// lblMaterialId
			// 
			this.lblMaterialId.AutoSize = true;
			this.lblMaterialId.Location = new System.Drawing.Point(11, 120);
			this.lblMaterialId.Name = "lblMaterialId";
			this.lblMaterialId.Size = new System.Drawing.Size(81, 20);
			this.lblMaterialId.TabIndex = 2;
			this.lblMaterialId.Text = "Material Id";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(11, 153);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(65, 20);
			this.lblQuantity.TabIndex = 3;
			this.lblQuantity.Text = "Quantity";
			// 
			// lblCostOfGood
			// 
			this.lblCostOfGood.AutoSize = true;
			this.lblCostOfGood.Location = new System.Drawing.Point(11, 186);
			this.lblCostOfGood.Name = "lblCostOfGood";
			this.lblCostOfGood.Size = new System.Drawing.Size(99, 20);
			this.lblCostOfGood.TabIndex = 4;
			this.lblCostOfGood.Text = "Cost Of Good";
			// 
			// lblRetailPrice
			// 
			this.lblRetailPrice.AutoSize = true;
			this.lblRetailPrice.Location = new System.Drawing.Point(11, 219);
			this.lblRetailPrice.Name = "lblRetailPrice";
			this.lblRetailPrice.Size = new System.Drawing.Size(83, 20);
			this.lblRetailPrice.TabIndex = 5;
			this.lblRetailPrice.Text = "Retail Price";
			// 
			// lblProductList
			// 
			this.lblProductList.AutoSize = true;
			this.lblProductList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProductList.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblProductList.Location = new System.Drawing.Point(305, -2);
			this.lblProductList.Name = "lblProductList";
			this.lblProductList.Size = new System.Drawing.Size(197, 46);
			this.lblProductList.TabIndex = 15;
			this.lblProductList.Text = "Product List";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnReload);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 398);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 52);
			this.panel1.TabIndex = 24;
			// 
			// btnClose
			// 
			this.btnClose.Image = global::SaleManagementClient.Properties.Resources.cropped__8_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(685, 11);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 29);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnReload
			// 
			this.btnReload.Image = global::SaleManagementClient.Properties.Resources.cropped__6_;
			this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReload.Location = new System.Drawing.Point(517, 11);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(94, 29);
			this.btnReload.TabIndex = 3;
			this.btnReload.Text = "&Reload";
			this.btnReload.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Image = global::SaleManagementClient.Properties.Resources.cropped__5_;
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdate.Location = new System.Drawing.Point(349, 11);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(94, 29);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Image = global::SaleManagementClient.Properties.Resources.cropped__3_;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(181, 11);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(94, 29);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = global::SaleManagementClient.Properties.Resources.cropped__1_;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(13, 11);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 29);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(113, 47);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(208, 27);
			this.txtProductId.TabIndex = 25;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(113, 80);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(208, 27);
			this.txtProductName.TabIndex = 26;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(113, 146);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(208, 27);
			this.txtQuantity.TabIndex = 27;
			// 
			// txtCostOfGood
			// 
			this.txtCostOfGood.Location = new System.Drawing.Point(113, 179);
			this.txtCostOfGood.Name = "txtCostOfGood";
			this.txtCostOfGood.Size = new System.Drawing.Size(208, 27);
			this.txtCostOfGood.TabIndex = 28;
			// 
			// txtRetailPrice
			// 
			this.txtRetailPrice.Location = new System.Drawing.Point(113, 212);
			this.txtRetailPrice.Name = "txtRetailPrice";
			this.txtRetailPrice.Size = new System.Drawing.Size(208, 27);
			this.txtRetailPrice.TabIndex = 29;
			// 
			// cboMaterialId
			// 
			this.cboMaterialId.FormattingEnabled = true;
			this.cboMaterialId.Location = new System.Drawing.Point(113, 115);
			this.cboMaterialId.Name = "cboMaterialId";
			this.cboMaterialId.Size = new System.Drawing.Size(208, 28);
			this.cboMaterialId.TabIndex = 30;
			this.cboMaterialId.SelectedIndexChanged += new System.EventHandler(this.IndexChanged);
			// 
			// dgvProducts
			// 
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Location = new System.Drawing.Point(0, 242);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RowHeadersWidth = 51;
			this.dgvProducts.RowTemplate.Height = 29;
			this.dgvProducts.Size = new System.Drawing.Size(800, 150);
			this.dgvProducts.TabIndex = 31;
			this.dgvProducts.Click += new System.EventHandler(this.onDgv_Click);
			// 
			// lblImage
			// 
			this.lblImage.AutoSize = true;
			this.lblImage.Location = new System.Drawing.Point(326, 47);
			this.lblImage.Name = "lblImage";
			this.lblImage.Size = new System.Drawing.Size(51, 20);
			this.lblImage.TabIndex = 32;
			this.lblImage.Text = "Image";
			// 
			// txtImage
			// 
			this.txtImage.Location = new System.Drawing.Point(383, 47);
			this.txtImage.Multiline = true;
			this.txtImage.Name = "txtImage";
			this.txtImage.Size = new System.Drawing.Size(191, 93);
			this.txtImage.TabIndex = 33;
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(383, 153);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(191, 86);
			this.txtNote.TabIndex = 34;
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.Location = new System.Drawing.Point(327, 156);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(42, 20);
			this.lblNote.TabIndex = 35;
			this.lblNote.Text = "Note";
			// 
			// picImage
			// 
			this.picImage.Location = new System.Drawing.Point(589, 47);
			this.picImage.Name = "picImage";
			this.picImage.Size = new System.Drawing.Size(199, 192);
			this.picImage.TabIndex = 36;
			this.picImage.TabStop = false;
			// 
			// frmProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.picImage);
			this.Controls.Add(this.lblNote);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.txtImage);
			this.Controls.Add(this.lblImage);
			this.Controls.Add(this.dgvProducts);
			this.Controls.Add(this.cboMaterialId);
			this.Controls.Add(this.txtRetailPrice);
			this.Controls.Add(this.txtCostOfGood);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblProductList);
			this.Controls.Add(this.lblRetailPrice);
			this.Controls.Add(this.lblCostOfGood);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.lblMaterialId);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.lblProductId);
			this.Name = "frmProducts";
			this.Text = "frmProduct";
			this.Load += new System.EventHandler(this.onFrmLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblProductId;
		private Label lblProductName;
		private Label lblMaterialId;
		private Label lblQuantity;
		private Label lblCostOfGood;
		private Label lblRetailPrice;
		private Label lblProductList;
		private Panel panel1;
		private Button btnClose;
		private Button btnReload;
		private Button btnUpdate;
		private Button btnDelete;
		private Button btnAdd;
		private TextBox txtProductId;
		private TextBox txtProductName;
		private TextBox txtQuantity;
		private TextBox txtCostOfGood;
		private TextBox txtRetailPrice;
		private ComboBox cboMaterialId;
		private DataGridView dgvProducts;
		private Label lblImage;
		private TextBox txtImage;
		private TextBox txtNote;
		private Label lblNote;
		private PictureBox picImage;
	}
}