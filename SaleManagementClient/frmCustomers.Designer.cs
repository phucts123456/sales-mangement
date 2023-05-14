namespace SaleManagementClient
{
	partial class frmCustomers
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
			this.lblCustomerId = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.dgvCustomers = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCustomerId
			// 
			this.lblCustomerId.AutoSize = true;
			this.lblCustomerId.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCustomerId.Location = new System.Drawing.Point(38, 63);
			this.lblCustomerId.Name = "lblCustomerId";
			this.lblCustomerId.Size = new System.Drawing.Size(72, 15);
			this.lblCustomerId.TabIndex = 0;
			this.lblCustomerId.Text = "Customer Id";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(298, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(178, 37);
			this.label7.TabIndex = 14;
			this.label7.Text = "Customer List";
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCustomerName.Location = new System.Drawing.Point(38, 119);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(94, 15);
			this.lblCustomerName.TabIndex = 15;
			this.lblCustomerName.Text = "Customer Name";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblAddress.Location = new System.Drawing.Point(411, 63);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblAddress.Size = new System.Drawing.Size(49, 15);
			this.lblAddress.TabIndex = 16;
			this.lblAddress.Text = "Address";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPhoneNumber.Location = new System.Drawing.Point(411, 116);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(85, 15);
			this.lblPhoneNumber.TabIndex = 17;
			this.lblPhoneNumber.Text = "PhoneNumber";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(138, 111);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(267, 23);
			this.txtCustomerName.TabIndex = 18;
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Location = new System.Drawing.Point(138, 55);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(267, 23);
			this.txtCustomerId.TabIndex = 19;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(505, 55);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(267, 23);
			this.txtAddress.TabIndex = 20;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(505, 113);
			this.txtPhoneNumber.Mask = "(+84) 000-000-000";
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(267, 23);
			this.txtPhoneNumber.TabIndex = 21;
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Location = new System.Drawing.Point(0, 152);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.RowTemplate.Height = 25;
			this.dgvCustomers.Size = new System.Drawing.Size(800, 245);
			this.dgvCustomers.TabIndex = 22;
			this.dgvCustomers.Click += new System.EventHandler(this.onDgvClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnReload);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 411);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 39);
			this.panel1.TabIndex = 23;
			// 
			// btnClose
			// 
			this.btnClose.Image = global::SaleManagementClient.Properties.Resources.cropped__8_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(688, 10);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(82, 22);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnReload
			// 
			this.btnReload.Image = global::SaleManagementClient.Properties.Resources.cropped__6_;
			this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReload.Location = new System.Drawing.Point(523, 11);
			this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(82, 22);
			this.btnReload.TabIndex = 3;
			this.btnReload.Text = "&Reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Image = global::SaleManagementClient.Properties.Resources.cropped__5_;
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdate.Location = new System.Drawing.Point(358, 10);
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
			this.btnDelete.Location = new System.Drawing.Point(193, 10);
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
			// frmCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvCustomers);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblCustomerName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblCustomerId);
			this.Name = "frmCustomers";
			this.Text = "frmCustomers";
			this.Load += new System.EventHandler(this.onFrmLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblCustomerId;
		private Label label7;
		private Label lblCustomerName;
		private Label lblAddress;
		private Label lblPhoneNumber;
		private TextBox txtCustomerName;
		private TextBox txtCustomerId;
		private TextBox txtAddress;
		private MaskedTextBox txtPhoneNumber;
		private DataGridView dgvCustomers;
		private Panel panel1;
		private Button btnClose;
		private Button btnReload;
		private Button btnUpdate;
		private Button btnDelete;
		private Button btnAdd;
	}
}