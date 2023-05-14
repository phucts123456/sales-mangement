namespace SaleManagementClient
{
	partial class frmUpdateOrCreateProduct
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
			this.pnlUpdateOrCreateProductForm = new System.Windows.Forms.Panel();
			this.btnUpload = new System.Windows.Forms.Button();
			this.picImage = new System.Windows.Forms.PictureBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbMaterialId = new System.Windows.Forms.ComboBox();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.txtImage = new System.Windows.Forms.TextBox();
			this.txtRetailPrice = new System.Windows.Forms.TextBox();
			this.txtCostOfGood = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblMaterialId = new System.Windows.Forms.Label();
			this.lblNote = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblRetailPrice = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblCreateOrUpdateProduct = new System.Windows.Forms.Label();
			this.pnlUpdateOrCreateProductForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlUpdateOrCreateProductForm
			// 
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.btnUpload);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.picImage);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.btnCancel);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.btnSave);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.cbMaterialId);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.txtNote);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.txtImage);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.txtRetailPrice);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.txtCostOfGood);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.txtQuantity);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.txtProductName);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.lblQuantity);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.lblMaterialId);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.lblNote);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.label5);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.lblRetailPrice);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.lblProductName);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.label2);
			this.pnlUpdateOrCreateProductForm.Controls.Add(this.lblCreateOrUpdateProduct);
			this.pnlUpdateOrCreateProductForm.Location = new System.Drawing.Point(41, -2);
			this.pnlUpdateOrCreateProductForm.Name = "pnlUpdateOrCreateProductForm";
			this.pnlUpdateOrCreateProductForm.Size = new System.Drawing.Size(718, 453);
			this.pnlUpdateOrCreateProductForm.TabIndex = 0;
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(538, 236);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(122, 29);
			this.btnUpload.TabIndex = 35;
			this.btnUpload.Text = "Upload Photo";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// picImage
			// 
			this.picImage.Location = new System.Drawing.Point(486, 45);
			this.picImage.Name = "picImage";
			this.picImage.Size = new System.Drawing.Size(217, 173);
			this.picImage.TabIndex = 34;
			this.picImage.TabStop = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(139, 411);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(94, 29);
			this.btnCancel.TabIndex = 33;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(365, 411);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(94, 29);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbMaterialId
			// 
			this.cbMaterialId.FormattingEnabled = true;
			this.cbMaterialId.Location = new System.Drawing.Point(139, 81);
			this.cbMaterialId.Name = "cbMaterialId";
			this.cbMaterialId.Size = new System.Drawing.Size(320, 28);
			this.cbMaterialId.TabIndex = 32;
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(139, 303);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(320, 91);
			this.txtNote.TabIndex = 31;
			// 
			// txtImage
			// 
			this.txtImage.Location = new System.Drawing.Point(139, 226);
			this.txtImage.Multiline = true;
			this.txtImage.Name = "txtImage";
			this.txtImage.Size = new System.Drawing.Size(320, 68);
			this.txtImage.TabIndex = 30;
			// 
			// txtRetailPrice
			// 
			this.txtRetailPrice.Location = new System.Drawing.Point(139, 190);
			this.txtRetailPrice.Name = "txtRetailPrice";
			this.txtRetailPrice.Size = new System.Drawing.Size(320, 27);
			this.txtRetailPrice.TabIndex = 29;
			// 
			// txtCostOfGood
			// 
			this.txtCostOfGood.Location = new System.Drawing.Point(139, 154);
			this.txtCostOfGood.Name = "txtCostOfGood";
			this.txtCostOfGood.Size = new System.Drawing.Size(320, 27);
			this.txtCostOfGood.TabIndex = 28;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(139, 118);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(320, 27);
			this.txtQuantity.TabIndex = 27;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(139, 45);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(320, 27);
			this.txtProductName.TabIndex = 26;
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(29, 118);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(65, 20);
			this.lblQuantity.TabIndex = 24;
			this.lblQuantity.Text = "Quantity";
			// 
			// lblMaterialId
			// 
			this.lblMaterialId.AutoSize = true;
			this.lblMaterialId.Location = new System.Drawing.Point(29, 81);
			this.lblMaterialId.Name = "lblMaterialId";
			this.lblMaterialId.Size = new System.Drawing.Size(81, 20);
			this.lblMaterialId.TabIndex = 23;
			this.lblMaterialId.Text = "Material Id";
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.Location = new System.Drawing.Point(29, 303);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(42, 20);
			this.lblNote.TabIndex = 22;
			this.lblNote.Text = "Note";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "Image";
			// 
			// lblRetailPrice
			// 
			this.lblRetailPrice.AutoSize = true;
			this.lblRetailPrice.Location = new System.Drawing.Point(29, 190);
			this.lblRetailPrice.Name = "lblRetailPrice";
			this.lblRetailPrice.Size = new System.Drawing.Size(83, 20);
			this.lblRetailPrice.TabIndex = 20;
			this.lblRetailPrice.Text = "Retail Price";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(29, 45);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(104, 20);
			this.lblProductName.TabIndex = 19;
			this.lblProductName.Text = "Product Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 20);
			this.label2.TabIndex = 18;
			this.label2.Text = "Cost Of Good";
			// 
			// lblCreateOrUpdateProduct
			// 
			this.lblCreateOrUpdateProduct.AutoSize = true;
			this.lblCreateOrUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCreateOrUpdateProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCreateOrUpdateProduct.Location = new System.Drawing.Point(231, 0);
			this.lblCreateOrUpdateProduct.Name = "lblCreateOrUpdateProduct";
			this.lblCreateOrUpdateProduct.Size = new System.Drawing.Size(236, 46);
			this.lblCreateOrUpdateProduct.TabIndex = 16;
			this.lblCreateOrUpdateProduct.Text = "Add a product";
			// 
			// frmUpdateOrCreateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlUpdateOrCreateProductForm);
			this.Name = "frmUpdateOrCreateProduct";
			this.Text = "frmUpdateOrCreateProduct";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onForm_Closed);
			this.Load += new System.EventHandler(this.onFrm_Load);
			this.pnlUpdateOrCreateProductForm.ResumeLayout(false);
			this.pnlUpdateOrCreateProductForm.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlUpdateOrCreateProductForm;
		private Label lblCreateOrUpdateProduct;
		private Label lblQuantity;
		private Label lblMaterialId;
		private Label lblNote;
		private Label label5;
		private Label lblRetailPrice;
		private Label lblProductName;
		private Label label2;
		private TextBox txtNote;
		private TextBox txtImage;
		private TextBox txtRetailPrice;
		private TextBox txtCostOfGood;
		private TextBox txtQuantity;
		private TextBox txtProductName;
		private Button btnCancel;
		private Button btnSave;
		private ComboBox cbMaterialId;
		private PictureBox picImage;
		private Button btnUpload;
	}
}