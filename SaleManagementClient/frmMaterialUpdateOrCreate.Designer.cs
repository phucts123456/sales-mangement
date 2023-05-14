namespace SaleManagementClient
{
	partial class frmMaterialUpdateOrCreate
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtMaterialName = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblMaterialName = new System.Windows.Forms.Label();
			this.lblCreateOrUpdateEmployee = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtMaterialName);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.lblMaterialName);
			this.panel1.Controls.Add(this.lblCreateOrUpdateEmployee);
			this.panel1.Location = new System.Drawing.Point(175, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 452);
			this.panel1.TabIndex = 0;
			// 
			// txtMaterialName
			// 
			this.txtMaterialName.Location = new System.Drawing.Point(128, 63);
			this.txtMaterialName.Name = "txtMaterialName";
			this.txtMaterialName.Size = new System.Drawing.Size(286, 27);
			this.txtMaterialName.TabIndex = 7;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(243, 140);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(94, 29);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(84, 140);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(94, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblMaterialName
			// 
			this.lblMaterialName.AutoSize = true;
			this.lblMaterialName.Location = new System.Drawing.Point(18, 70);
			this.lblMaterialName.Name = "lblMaterialName";
			this.lblMaterialName.Size = new System.Drawing.Size(104, 20);
			this.lblMaterialName.TabIndex = 3;
			this.lblMaterialName.Text = "MaterialName";
			// 
			// lblCreateOrUpdateEmployee
			// 
			this.lblCreateOrUpdateEmployee.AutoSize = true;
			this.lblCreateOrUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCreateOrUpdateEmployee.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCreateOrUpdateEmployee.Location = new System.Drawing.Point(124, 9);
			this.lblCreateOrUpdateEmployee.Name = "lblCreateOrUpdateEmployee";
			this.lblCreateOrUpdateEmployee.Size = new System.Drawing.Size(203, 35);
			this.lblCreateOrUpdateEmployee.TabIndex = 1;
			this.lblCreateOrUpdateEmployee.Text = "Create a Material";
			// 
			// frmMaterialUpdateOrCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "frmMaterialUpdateOrCreate";
			this.Text = "frmMaterialUpdateOrCreate";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClosed);
			this.Load += new System.EventHandler(this.onFrmLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Label lblCreateOrUpdateEmployee;
		private Button btnSave;
		private Button btnCancel;
		private Label lblMaterialName;
		private TextBox txtMaterialName;
	}
}