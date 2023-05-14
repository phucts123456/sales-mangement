namespace SaleManagementClient
{
	partial class frmEmployeeUpdateOrCreate
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
			this.pnlParent = new System.Windows.Forms.Panel();
			this.pnlForm = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtDateOfBirth = new System.Windows.Forms.MaskedTextBox();
			this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.cbFemale = new System.Windows.Forms.CheckBox();
			this.cbMale = new System.Windows.Forms.CheckBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.lblDateOfBirth = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblSex = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblCreateOrUpdateEmployee = new System.Windows.Forms.Label();
			this.pnlParent.SuspendLayout();
			this.pnlForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlParent
			// 
			this.pnlParent.Controls.Add(this.pnlForm);
			this.pnlParent.Location = new System.Drawing.Point(0, -1);
			this.pnlParent.Name = "pnlParent";
			this.pnlParent.Size = new System.Drawing.Size(800, 452);
			this.pnlParent.TabIndex = 0;
			// 
			// pnlForm
			// 
			this.pnlForm.Controls.Add(this.btnSave);
			this.pnlForm.Controls.Add(this.btnCancel);
			this.pnlForm.Controls.Add(this.txtDateOfBirth);
			this.pnlForm.Controls.Add(this.txtPhoneNumber);
			this.pnlForm.Controls.Add(this.cbFemale);
			this.pnlForm.Controls.Add(this.cbMale);
			this.pnlForm.Controls.Add(this.txtAddress);
			this.pnlForm.Controls.Add(this.txtEmployeeName);
			this.pnlForm.Controls.Add(this.lblDateOfBirth);
			this.pnlForm.Controls.Add(this.lblPhoneNumber);
			this.pnlForm.Controls.Add(this.lblAddress);
			this.pnlForm.Controls.Add(this.lblSex);
			this.pnlForm.Controls.Add(this.label2);
			this.pnlForm.Controls.Add(this.lblCreateOrUpdateEmployee);
			this.pnlForm.Location = new System.Drawing.Point(140, 0);
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Size = new System.Drawing.Size(521, 452);
			this.pnlForm.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(343, 356);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(94, 29);
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(92, 356);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(94, 29);
			this.btnCancel.TabIndex = 17;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtDateOfBirth
			// 
			this.txtDateOfBirth.Location = new System.Drawing.Point(149, 302);
			this.txtDateOfBirth.Mask = "00/00/0000";
			this.txtDateOfBirth.Name = "txtDateOfBirth";
			this.txtDateOfBirth.Size = new System.Drawing.Size(337, 27);
			this.txtDateOfBirth.TabIndex = 16;
			this.txtDateOfBirth.ValidatingType = typeof(System.DateTime);
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(149, 239);
			this.txtPhoneNumber.Mask = "(+99) 0000-0000";
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(337, 27);
			this.txtPhoneNumber.TabIndex = 15;
			// 
			// cbFemale
			// 
			this.cbFemale.AutoSize = true;
			this.cbFemale.Location = new System.Drawing.Point(280, 128);
			this.cbFemale.Name = "cbFemale";
			this.cbFemale.Size = new System.Drawing.Size(79, 24);
			this.cbFemale.TabIndex = 14;
			this.cbFemale.Text = "Female";
			this.cbFemale.UseVisualStyleBackColor = true;
			// 
			// cbMale
			// 
			this.cbMale.AutoSize = true;
			this.cbMale.Location = new System.Drawing.Point(149, 128);
			this.cbMale.Name = "cbMale";
			this.cbMale.Size = new System.Drawing.Size(64, 24);
			this.cbMale.TabIndex = 13;
			this.cbMale.Text = "Male";
			this.cbMale.UseVisualStyleBackColor = true;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(149, 184);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(337, 27);
			this.txtAddress.TabIndex = 10;
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(149, 66);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(337, 27);
			this.txtEmployeeName.TabIndex = 8;
			// 
			// lblDateOfBirth
			// 
			this.lblDateOfBirth.AutoSize = true;
			this.lblDateOfBirth.Location = new System.Drawing.Point(28, 309);
			this.lblDateOfBirth.Name = "lblDateOfBirth";
			this.lblDateOfBirth.Size = new System.Drawing.Size(88, 20);
			this.lblDateOfBirth.TabIndex = 6;
			this.lblDateOfBirth.Text = "DateOfBirth";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Location = new System.Drawing.Point(28, 246);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(104, 20);
			this.lblPhoneNumber.TabIndex = 5;
			this.lblPhoneNumber.Text = "PhoneNumber";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(28, 191);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(62, 20);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address";
			// 
			// lblSex
			// 
			this.lblSex.AutoSize = true;
			this.lblSex.Location = new System.Drawing.Point(28, 128);
			this.lblSex.Name = "lblSex";
			this.lblSex.Size = new System.Drawing.Size(32, 20);
			this.lblSex.TabIndex = 3;
			this.lblSex.Text = "Sex";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "EmployeeName";
			// 
			// lblCreateOrUpdateEmployee
			// 
			this.lblCreateOrUpdateEmployee.AutoSize = true;
			this.lblCreateOrUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCreateOrUpdateEmployee.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCreateOrUpdateEmployee.Location = new System.Drawing.Point(149, 10);
			this.lblCreateOrUpdateEmployee.Name = "lblCreateOrUpdateEmployee";
			this.lblCreateOrUpdateEmployee.Size = new System.Drawing.Size(236, 35);
			this.lblCreateOrUpdateEmployee.TabIndex = 0;
			this.lblCreateOrUpdateEmployee.Text = "Create an employee";
			// 
			// frmEmployeeUpdateOrCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlParent);
			this.Name = "frmEmployeeUpdateOrCreate";
			this.Text = "frmEmployeeUpdateOrCreate";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClosed);
			this.Load += new System.EventHandler(this.onFrmLoad);
			this.pnlParent.ResumeLayout(false);
			this.pnlForm.ResumeLayout(false);
			this.pnlForm.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlParent;
		private Panel pnlForm;
		private TextBox txtAddress;
		private TextBox txtEmployeeName;
		private Label lblDateOfBirth;
		private Label lblPhoneNumber;
		private Label lblAddress;
		private Label lblSex;
		private Label label2;
		private Label lblCreateOrUpdateEmployee;
		private CheckBox cbFemale;
		private CheckBox cbMale;
		private MaskedTextBox txtDateOfBirth;
		private MaskedTextBox txtPhoneNumber;
		private Button btnSave;
		private Button btnCancel;
	}
}