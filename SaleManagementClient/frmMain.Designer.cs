namespace SaleManagementClient
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ordersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.lblMain = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.pnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(800, 30);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.UseWaitCursor = true;
			// 
			// listToolStripMenuItem
			// 
			this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.materialsToolStripMenuItem});
			this.listToolStripMenuItem.Name = "listToolStripMenuItem";
			this.listToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
			this.listToolStripMenuItem.Text = "List";
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.productsToolStripMenuItem.Text = "Products";
			this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
			// 
			// employeesToolStripMenuItem
			// 
			this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
			this.employeesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.employeesToolStripMenuItem.Text = "Employees";
			this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
			// 
			// customersToolStripMenuItem
			// 
			this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
			this.customersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.customersToolStripMenuItem.Text = "Customers";
			this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
			// 
			// ordersToolStripMenuItem
			// 
			this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
			this.ordersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.ordersToolStripMenuItem.Text = "Orders";
			// 
			// materialsToolStripMenuItem
			// 
			this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
			this.materialsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.materialsToolStripMenuItem.Text = "Materials";
			this.materialsToolStripMenuItem.Click += new System.EventHandler(this.materialsToolStripMenuItem_Click);
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem1});
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.searchToolStripMenuItem.Text = "Search";
			// 
			// ordersToolStripMenuItem1
			// 
			this.ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
			this.ordersToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
			this.ordersToolStripMenuItem1.Text = "Orders";
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleReportToolStripMenuItem});
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.reportsToolStripMenuItem.Text = "Reports";
			// 
			// saleReportToolStripMenuItem
			// 
			this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
			this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
			this.saleReportToolStripMenuItem.Text = "Sale Report";
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.lblMain);
			this.pnlMain.Location = new System.Drawing.Point(0, 31);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(800, 419);
			this.pnlMain.TabIndex = 1;
			this.pnlMain.UseWaitCursor = true;
			// 
			// lblMain
			// 
			this.lblMain.AutoSize = true;
			this.lblMain.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMain.Location = new System.Drawing.Point(125, 176);
			this.lblMain.Name = "lblMain";
			this.lblMain.Size = new System.Drawing.Size(550, 67);
			this.lblMain.TabIndex = 0;
			this.lblMain.Text = "Sales Management App";
			this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMain.UseWaitCursor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 451);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "Main Form";
			this.UseWaitCursor = true;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private Panel pnlMain;
		private ToolStripMenuItem listToolStripMenuItem;
		private ToolStripMenuItem searchToolStripMenuItem;
		private ToolStripMenuItem reportsToolStripMenuItem;
		private Label lblMain;
		private ToolStripMenuItem productsToolStripMenuItem;
		private ToolStripMenuItem employeesToolStripMenuItem;
		private ToolStripMenuItem customersToolStripMenuItem;
		private ToolStripMenuItem ordersToolStripMenuItem;
		private ToolStripMenuItem ordersToolStripMenuItem1;
		private ToolStripMenuItem saleReportToolStripMenuItem;
		private ToolStripMenuItem materialsToolStripMenuItem;
	}
}