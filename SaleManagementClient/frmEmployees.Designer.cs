namespace SaleManagementClient
{
	partial class frmEmployees
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
			this.txtDateOfBirth = new System.Windows.Forms.MaskedTextBox();
			this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.cbMale = new System.Windows.Forms.CheckBox();
			this.lblEmployeeID = new System.Windows.Forms.Label();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblSex = new System.Windows.Forms.Label();
			this.lblDateOfBirth = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvEmlpoyees = new System.Windows.Forms.DataGridView();
			this.cbFemale = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmlpoyees)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDateOfBirth
			// 
			this.txtDateOfBirth.Location = new System.Drawing.Point(464, 130);
			this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDateOfBirth.Mask = "00/00/0000";
			this.txtDateOfBirth.Name = "txtDateOfBirth";
			this.txtDateOfBirth.Size = new System.Drawing.Size(226, 23);
			this.txtDateOfBirth.TabIndex = 0;
			this.txtDateOfBirth.ValidatingType = typeof(System.DateTime);
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(464, 91);
			this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPhoneNumber.Mask = "(+99) 000-00000";
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(226, 23);
			this.txtPhoneNumber.TabIndex = 1;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(464, 50);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(226, 23);
			this.txtAddress.TabIndex = 2;
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Location = new System.Drawing.Point(116, 50);
			this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(226, 23);
			this.txtEmployeeID.TabIndex = 3;
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(116, 91);
			this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(226, 23);
			this.txtEmployeeName.TabIndex = 4;
			// 
			// cbMale
			// 
			this.cbMale.AutoSize = true;
			this.cbMale.Location = new System.Drawing.Point(116, 134);
			this.cbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbMale.Name = "cbMale";
			this.cbMale.Size = new System.Drawing.Size(52, 19);
			this.cbMale.TabIndex = 5;
			this.cbMale.Text = "Male";
			this.cbMale.UseVisualStyleBackColor = true;
			// 
			// lblEmployeeID
			// 
			this.lblEmployeeID.AutoSize = true;
			this.lblEmployeeID.Location = new System.Drawing.Point(10, 52);
			this.lblEmployeeID.Name = "lblEmployeeID";
			this.lblEmployeeID.Size = new System.Drawing.Size(70, 15);
			this.lblEmployeeID.TabIndex = 6;
			this.lblEmployeeID.Text = "EmployeeID";
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.AutoSize = true;
			this.lblEmployeeName.Location = new System.Drawing.Point(10, 96);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(91, 15);
			this.lblEmployeeName.TabIndex = 7;
			this.lblEmployeeName.Text = "EmployeeName";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(368, 55);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(49, 15);
			this.lblAddress.TabIndex = 8;
			this.lblAddress.Text = "Address";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Location = new System.Drawing.Point(368, 93);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(85, 15);
			this.lblPhoneNumber.TabIndex = 9;
			this.lblPhoneNumber.Text = "PhoneNumber";
			// 
			// lblSex
			// 
			this.lblSex.AutoSize = true;
			this.lblSex.Location = new System.Drawing.Point(10, 135);
			this.lblSex.Name = "lblSex";
			this.lblSex.Size = new System.Drawing.Size(25, 15);
			this.lblSex.TabIndex = 10;
			this.lblSex.Text = "Sex";
			// 
			// lblDateOfBirth
			// 
			this.lblDateOfBirth.AutoSize = true;
			this.lblDateOfBirth.Location = new System.Drawing.Point(368, 134);
			this.lblDateOfBirth.Name = "lblDateOfBirth";
			this.lblDateOfBirth.Size = new System.Drawing.Size(69, 15);
			this.lblDateOfBirth.TabIndex = 11;
			this.lblDateOfBirth.Text = "DateOfBirth";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(272, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(181, 37);
			this.label7.TabIndex = 12;
			this.label7.Text = "Employee List";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnReload);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 299);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(700, 39);
			this.panel1.TabIndex = 13;
			// 
			// btnClose
			// 
			this.btnClose.Image = global::SaleManagementClient.Properties.Resources.cropped__8_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(595, 10);
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
			this.btnReload.Location = new System.Drawing.Point(451, 10);
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
			this.btnUpdate.Location = new System.Drawing.Point(307, 11);
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
			this.btnDelete.Location = new System.Drawing.Point(163, 10);
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
			this.btnAdd.Location = new System.Drawing.Point(19, 11);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(82, 22);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvEmlpoyees
			// 
			this.dgvEmlpoyees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmlpoyees.Location = new System.Drawing.Point(-1, 159);
			this.dgvEmlpoyees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvEmlpoyees.Name = "dgvEmlpoyees";
			this.dgvEmlpoyees.RowHeadersWidth = 51;
			this.dgvEmlpoyees.RowTemplate.Height = 29;
			this.dgvEmlpoyees.Size = new System.Drawing.Size(701, 141);
			this.dgvEmlpoyees.TabIndex = 14;
			this.dgvEmlpoyees.Click += new System.EventHandler(this.onDgvClick);
			// 
			// cbFemale
			// 
			this.cbFemale.AutoSize = true;
			this.cbFemale.Location = new System.Drawing.Point(195, 134);
			this.cbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbFemale.Name = "cbFemale";
			this.cbFemale.Size = new System.Drawing.Size(64, 19);
			this.cbFemale.TabIndex = 15;
			this.cbFemale.Text = "Female";
			this.cbFemale.UseVisualStyleBackColor = true;
			// 
			// frmEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 338);
			this.Controls.Add(this.cbFemale);
			this.Controls.Add(this.dgvEmlpoyees);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblDateOfBirth);
			this.Controls.Add(this.lblSex);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblEmployeeName);
			this.Controls.Add(this.lblEmployeeID);
			this.Controls.Add(this.cbMale);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.txtEmployeeID);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtDateOfBirth);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmEmployees";
			this.Text = "Employees";
			this.Load += new System.EventHandler(this.onFrmMainLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmlpoyees)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaskedTextBox txtDateOfBirth;
		private MaskedTextBox txtPhoneNumber;
		private TextBox txtAddress;
		private TextBox txtEmployeeID;
		private TextBox txtEmployeeName;
		private CheckBox cbMale;
		private Label lblEmployeeID;
		private Label lblEmployeeName;
		private Label lblAddress;
		private Label lblPhoneNumber;
		private Label lblSex;
		private Label lblDateOfBirth;
		private Label label7;
		private Panel panel1;
		private Button btnClose;
		private Button btnReload;
		private Button btnUpdate;
		private Button btnDelete;
		private Button btnAdd;
		private DataGridView dgvEmlpoyees;
		private CheckBox cbFemale;
	}
}