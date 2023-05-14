namespace SaleManagementClient
{
	partial class frmCustomerUpdateOrCreate
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
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblCreateOrUpdateCustomer = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Address ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "PhoneNumber";
			// 
			// lblCreateOrUpdateCustomer
			// 
			this.lblCreateOrUpdateCustomer.AutoSize = true;
			this.lblCreateOrUpdateCustomer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCreateOrUpdateCustomer.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCreateOrUpdateCustomer.Location = new System.Drawing.Point(157, 9);
			this.lblCreateOrUpdateCustomer.Name = "lblCreateOrUpdateCustomer";
			this.lblCreateOrUpdateCustomer.Size = new System.Drawing.Size(203, 37);
			this.lblCreateOrUpdateCustomer.TabIndex = 15;
			this.lblCreateOrUpdateCustomer.Text = "Add a customer";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.txtCustomerName);
			this.panel1.Controls.Add(this.txtPhoneNumber);
			this.panel1.Controls.Add(this.lblCreateOrUpdateCustomer);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(148, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(505, 449);
			this.panel1.TabIndex = 4;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(134, 170);
			this.txtPhoneNumber.Mask = "(+84) 000-000-000";
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(333, 23);
			this.txtPhoneNumber.TabIndex = 16;
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(134, 68);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(333, 23);
			this.txtCustomerName.TabIndex = 17;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(134, 118);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(333, 23);
			this.txtAddress.TabIndex = 18;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(134, 235);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 19;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(309, 235);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmCustomerUpdateOrCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "frmCustomerUpdateOrCreate";
			this.Text = "frmCustomerUpdateOrCreate";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFrmClose);
			this.Load += new System.EventHandler(this.onFrmLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Label label3;
		private Label label1;
		private Label label4;
		private Label lblCreateOrUpdateCustomer;
		private Panel panel1;
		private Button btnSave;
		private Button btnCancel;
		private TextBox txtAddress;
		private TextBox txtCustomerName;
		private MaskedTextBox txtPhoneNumber;
	}
}