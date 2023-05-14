namespace SaleManagementClient
{
	partial class frmMaterials
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
			this.label7 = new System.Windows.Forms.Label();
			this.lblMaterialId = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaterialName = new System.Windows.Forms.TextBox();
			this.txtMaterialId = new System.Windows.Forms.TextBox();
			this.dgvMaterials = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(262, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(162, 37);
			this.label7.TabIndex = 13;
			this.label7.Text = "Material List";
			// 
			// lblMaterialId
			// 
			this.lblMaterialId.AutoSize = true;
			this.lblMaterialId.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMaterialId.Location = new System.Drawing.Point(10, 49);
			this.lblMaterialId.Name = "lblMaterialId";
			this.lblMaterialId.Size = new System.Drawing.Size(63, 15);
			this.lblMaterialId.TabIndex = 14;
			this.lblMaterialId.Text = "Material Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(10, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 15);
			this.label2.TabIndex = 15;
			this.label2.Text = "Material Name";
			// 
			// txtMaterialName
			// 
			this.txtMaterialName.Location = new System.Drawing.Point(107, 82);
			this.txtMaterialName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMaterialName.Name = "txtMaterialName";
			this.txtMaterialName.Size = new System.Drawing.Size(332, 23);
			this.txtMaterialName.TabIndex = 16;
			// 
			// txtMaterialId
			// 
			this.txtMaterialId.Location = new System.Drawing.Point(107, 44);
			this.txtMaterialId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMaterialId.Name = "txtMaterialId";
			this.txtMaterialId.Size = new System.Drawing.Size(332, 23);
			this.txtMaterialId.TabIndex = 17;
			// 
			// dgvMaterials
			// 
			this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMaterials.Location = new System.Drawing.Point(0, 121);
			this.dgvMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMaterials.Name = "dgvMaterials";
			this.dgvMaterials.RowHeadersWidth = 51;
			this.dgvMaterials.RowTemplate.Height = 29;
			this.dgvMaterials.Size = new System.Drawing.Size(700, 173);
			this.dgvMaterials.TabIndex = 18;
			this.dgvMaterials.Click += new System.EventHandler(this.onDgvClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 299);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(700, 39);
			this.panel1.TabIndex = 19;
			// 
			// btnClose
			// 
			this.btnClose.Image = global::SaleManagementClient.Properties.Resources.cropped__8_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(584, 10);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(82, 22);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = global::SaleManagementClient.Properties.Resources.cropped__6_;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(445, 10);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(82, 22);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Reload";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.onBtnReload_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Image = global::SaleManagementClient.Properties.Resources.cropped__5_;
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdate.Location = new System.Drawing.Point(306, 10);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(82, 22);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Image = global::SaleManagementClient.Properties.Resources.cropped__3_;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(167, 10);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(82, 22);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = global::SaleManagementClient.Properties.Resources.cropped__1_;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(28, 10);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(82, 22);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmMaterials
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 338);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvMaterials);
			this.Controls.Add(this.txtMaterialId);
			this.Controls.Add(this.txtMaterialName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblMaterialId);
			this.Controls.Add(this.label7);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmMaterials";
			this.Text = "frmMaterials";
			this.Load += new System.EventHandler(this.onFrmLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label7;
		private Label lblMaterialId;
		private Label label2;
		private TextBox txtMaterialName;
		private TextBox txtMaterialId;
		private DataGridView dgvMaterials;
		private Panel panel1;
		private Button btnClose;
		private Button btnSave;
		private Button btnUpdate;
		private Button btnDelete;
		private Button btnAdd;
	}
}