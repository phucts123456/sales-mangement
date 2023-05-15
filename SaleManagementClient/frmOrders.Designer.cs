namespace SaleManagementClient
{
	partial class frmOrders
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
			this.cbOrders = new System.Windows.Forms.ComboBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.scOrders = new System.Windows.Forms.SplitContainer();
			this.lblOrderList = new System.Windows.Forms.Label();
			this.gbOrderInfor = new System.Windows.Forms.GroupBox();
			this.cbCustomerName = new System.Windows.Forms.ComboBox();
			this.cbEmployeeName = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtOrderId = new System.Windows.Forms.TextBox();
			this.txtOrderDate = new System.Windows.Forms.TextBox();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblOrderDate = new System.Windows.Forms.Label();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.gbOrder_Details = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cbProductName = new System.Windows.Forms.ComboBox();
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtRetailPrice = new System.Windows.Forms.TextBox();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblRetailPrice = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scOrders)).BeginInit();
			this.scOrders.Panel1.SuspendLayout();
			this.scOrders.Panel2.SuspendLayout();
			this.scOrders.SuspendLayout();
			this.gbOrderInfor.SuspendLayout();
			this.gbOrder_Details.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbOrders);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 407);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(804, 44);
			this.panel1.TabIndex = 0;
			// 
			// cbOrders
			// 
			this.cbOrders.FormattingEnabled = true;
			this.cbOrders.Location = new System.Drawing.Point(92, 10);
			this.cbOrders.Name = "cbOrders";
			this.cbOrders.Size = new System.Drawing.Size(269, 28);
			this.cbOrders.TabIndex = 3;
			this.cbOrders.SelectedIndexChanged += new System.EventHandler(this.onSelectedItem_Changed);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(367, 9);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(94, 29);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Order Id";
			// 
			// scOrders
			// 
			this.scOrders.Location = new System.Drawing.Point(0, 1);
			this.scOrders.Name = "scOrders";
			this.scOrders.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scOrders.Panel1
			// 
			this.scOrders.Panel1.Controls.Add(this.lblOrderList);
			this.scOrders.Panel1.Controls.Add(this.gbOrderInfor);
			// 
			// scOrders.Panel2
			// 
			this.scOrders.Panel2.Controls.Add(this.gbOrder_Details);
			this.scOrders.Size = new System.Drawing.Size(801, 409);
			this.scOrders.SplitterDistance = 152;
			this.scOrders.TabIndex = 1;
			// 
			// lblOrderList
			// 
			this.lblOrderList.AutoSize = true;
			this.lblOrderList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblOrderList.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOrderList.Location = new System.Drawing.Point(317, 0);
			this.lblOrderList.Name = "lblOrderList";
			this.lblOrderList.Size = new System.Drawing.Size(167, 46);
			this.lblOrderList.TabIndex = 15;
			this.lblOrderList.Text = "Order List";
			// 
			// gbOrderInfor
			// 
			this.gbOrderInfor.Controls.Add(this.cbCustomerName);
			this.gbOrderInfor.Controls.Add(this.cbEmployeeName);
			this.gbOrderInfor.Controls.Add(this.txtAddress);
			this.gbOrderInfor.Controls.Add(this.txtPhoneNumber);
			this.gbOrderInfor.Controls.Add(this.txtOrderId);
			this.gbOrderInfor.Controls.Add(this.txtOrderDate);
			this.gbOrderInfor.Controls.Add(this.lblEmployeeName);
			this.gbOrderInfor.Controls.Add(this.lblCustomerName);
			this.gbOrderInfor.Controls.Add(this.lblAddress);
			this.gbOrderInfor.Controls.Add(this.lblPhoneNumber);
			this.gbOrderInfor.Controls.Add(this.lblOrderDate);
			this.gbOrderInfor.Controls.Add(this.lblOrderId);
			this.gbOrderInfor.Location = new System.Drawing.Point(0, 37);
			this.gbOrderInfor.Name = "gbOrderInfor";
			this.gbOrderInfor.Size = new System.Drawing.Size(801, 118);
			this.gbOrderInfor.TabIndex = 0;
			this.gbOrderInfor.TabStop = false;
			this.gbOrderInfor.Text = "Order Information";
			// 
			// cbCustomerName
			// 
			this.cbCustomerName.FormattingEnabled = true;
			this.cbCustomerName.Location = new System.Drawing.Point(538, 20);
			this.cbCustomerName.Name = "cbCustomerName";
			this.cbCustomerName.Size = new System.Drawing.Size(242, 28);
			this.cbCustomerName.TabIndex = 17;
			// 
			// cbEmployeeName
			// 
			this.cbEmployeeName.FormattingEnabled = true;
			this.cbEmployeeName.Location = new System.Drawing.Point(137, 84);
			this.cbEmployeeName.Name = "cbEmployeeName";
			this.cbEmployeeName.Size = new System.Drawing.Size(242, 28);
			this.cbEmployeeName.TabIndex = 16;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(539, 52);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(242, 27);
			this.txtAddress.TabIndex = 14;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(539, 85);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(242, 27);
			this.txtPhoneNumber.TabIndex = 13;
			// 
			// txtOrderId
			// 
			this.txtOrderId.Location = new System.Drawing.Point(137, 20);
			this.txtOrderId.Name = "txtOrderId";
			this.txtOrderId.Size = new System.Drawing.Size(242, 27);
			this.txtOrderId.TabIndex = 10;
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.Location = new System.Drawing.Point(137, 52);
			this.txtOrderDate.Name = "txtOrderDate";
			this.txtOrderDate.Size = new System.Drawing.Size(242, 27);
			this.txtOrderDate.TabIndex = 9;
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.AutoSize = true;
			this.lblEmployeeName.Location = new System.Drawing.Point(11, 88);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(119, 20);
			this.lblEmployeeName.TabIndex = 7;
			this.lblEmployeeName.Text = "Employee Name";
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Location = new System.Drawing.Point(417, 28);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(116, 20);
			this.lblCustomerName.TabIndex = 5;
			this.lblCustomerName.Text = "Customer Name";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(417, 59);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(62, 20);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Location = new System.Drawing.Point(417, 92);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(104, 20);
			this.lblPhoneNumber.TabIndex = 3;
			this.lblPhoneNumber.Text = "PhoneNumber";
			// 
			// lblOrderDate
			// 
			this.lblOrderDate.AutoSize = true;
			this.lblOrderDate.Location = new System.Drawing.Point(12, 55);
			this.lblOrderDate.Name = "lblOrderDate";
			this.lblOrderDate.Size = new System.Drawing.Size(83, 20);
			this.lblOrderDate.TabIndex = 1;
			this.lblOrderDate.Text = "Order Date";
			// 
			// lblOrderId
			// 
			this.lblOrderId.AutoSize = true;
			this.lblOrderId.Location = new System.Drawing.Point(13, 23);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(64, 20);
			this.lblOrderId.TabIndex = 0;
			this.lblOrderId.Text = "Order Id";
			// 
			// gbOrder_Details
			// 
			this.gbOrder_Details.Controls.Add(this.btnClose);
			this.gbOrder_Details.Controls.Add(this.btnReload);
			this.gbOrder_Details.Controls.Add(this.label3);
			this.gbOrder_Details.Controls.Add(this.btnAdd);
			this.gbOrder_Details.Controls.Add(this.btnDelete);
			this.gbOrder_Details.Controls.Add(this.btnUpdate);
			this.gbOrder_Details.Controls.Add(this.label2);
			this.gbOrder_Details.Controls.Add(this.cbProductName);
			this.gbOrder_Details.Controls.Add(this.dgvOrders);
			this.gbOrder_Details.Controls.Add(this.txtTotal);
			this.gbOrder_Details.Controls.Add(this.txtRetailPrice);
			this.gbOrder_Details.Controls.Add(this.txtDiscount);
			this.gbOrder_Details.Controls.Add(this.txtQuantity);
			this.gbOrder_Details.Controls.Add(this.lblProductName);
			this.gbOrder_Details.Controls.Add(this.lblRetailPrice);
			this.gbOrder_Details.Controls.Add(this.lblQuantity);
			this.gbOrder_Details.Controls.Add(this.lblDiscount);
			this.gbOrder_Details.Controls.Add(this.lblTotal);
			this.gbOrder_Details.Location = new System.Drawing.Point(0, 0);
			this.gbOrder_Details.Name = "gbOrder_Details";
			this.gbOrder_Details.Size = new System.Drawing.Size(804, 254);
			this.gbOrder_Details.TabIndex = 0;
			this.gbOrder_Details.TabStop = false;
			this.gbOrder_Details.Text = "Order Details";
			// 
			// btnClose
			// 
			this.btnClose.Image = global::SaleManagementClient.Properties.Resources.cropped__8_;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(678, 220);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 30);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnReload
			// 
			this.btnReload.Image = global::SaleManagementClient.Properties.Resources.cropped__6_;
			this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReload.Location = new System.Drawing.Point(513, 220);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(94, 28);
			this.btnReload.TabIndex = 3;
			this.btnReload.Text = "&Reload";
			this.btnReload.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(678, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 20);
			this.label3.TabIndex = 32;
			this.label3.Text = "0";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = global::SaleManagementClient.Properties.Resources.cropped__1_;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(24, 221);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 27);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Image = global::SaleManagementClient.Properties.Resources.cropped__3_;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(187, 220);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(94, 28);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Image = global::SaleManagementClient.Properties.Resources.cropped__5_;
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdate.Location = new System.Drawing.Point(350, 221);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(94, 27);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(529, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 31;
			this.label2.Text = "Total Price";
			// 
			// cbProductName
			// 
			this.cbProductName.FormattingEnabled = true;
			this.cbProductName.Location = new System.Drawing.Point(113, 20);
			this.cbProductName.Name = "cbProductName";
			this.cbProductName.Size = new System.Drawing.Size(156, 28);
			this.cbProductName.TabIndex = 30;
			// 
			// dgvOrders
			// 
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Location = new System.Drawing.Point(-1, 87);
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.RowHeadersWidth = 51;
			this.dgvOrders.RowTemplate.Height = 29;
			this.dgvOrders.Size = new System.Drawing.Size(804, 110);
			this.dgvOrders.TabIndex = 29;
			this.dgvOrders.Click += new System.EventHandler(this.onDgv_Click);
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(584, 21);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(156, 27);
			this.txtTotal.TabIndex = 28;
			// 
			// txtRetailPrice
			// 
			this.txtRetailPrice.Location = new System.Drawing.Point(360, 52);
			this.txtRetailPrice.Name = "txtRetailPrice";
			this.txtRetailPrice.Size = new System.Drawing.Size(156, 27);
			this.txtRetailPrice.TabIndex = 27;
			// 
			// txtDiscount
			// 
			this.txtDiscount.Location = new System.Drawing.Point(360, 19);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(156, 27);
			this.txtDiscount.TabIndex = 26;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(113, 54);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(156, 27);
			this.txtQuantity.TabIndex = 24;
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(3, 19);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(104, 20);
			this.lblProductName.TabIndex = 22;
			this.lblProductName.Text = "Product Name";
			// 
			// lblRetailPrice
			// 
			this.lblRetailPrice.AutoSize = true;
			this.lblRetailPrice.Location = new System.Drawing.Point(275, 58);
			this.lblRetailPrice.Name = "lblRetailPrice";
			this.lblRetailPrice.Size = new System.Drawing.Size(79, 20);
			this.lblRetailPrice.TabIndex = 21;
			this.lblRetailPrice.Text = "Retai Price";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(6, 51);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(65, 20);
			this.lblQuantity.TabIndex = 20;
			this.lblQuantity.Text = "Quantity";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Location = new System.Drawing.Point(275, 19);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(67, 20);
			this.lblDiscount.TabIndex = 19;
			this.lblDiscount.Text = "Discount";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(539, 19);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(42, 20);
			this.lblTotal.TabIndex = 18;
			this.lblTotal.Text = "Total";
			// 
			// frmOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 450);
			this.Controls.Add(this.scOrders);
			this.Controls.Add(this.panel1);
			this.Name = "frmOrders";
			this.Text = "fromOrders";
			this.Load += new System.EventHandler(this.onFrm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.scOrders.Panel1.ResumeLayout(false);
			this.scOrders.Panel1.PerformLayout();
			this.scOrders.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scOrders)).EndInit();
			this.scOrders.ResumeLayout(false);
			this.gbOrderInfor.ResumeLayout(false);
			this.gbOrderInfor.PerformLayout();
			this.gbOrder_Details.ResumeLayout(false);
			this.gbOrder_Details.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Button btnSearch;
		private Label label1;
		private SplitContainer scOrders;
		private Label lblOrderList;
		private GroupBox gbOrder_Details;
		private ComboBox cbProductName;
		private DataGridView dgvOrders;
		private TextBox txtTotal;
		private TextBox txtRetailPrice;
		private TextBox txtDiscount;
		private TextBox txtQuantity;
		private Label lblProductName;
		private Label lblRetailPrice;
		private Label lblQuantity;
		private Label lblDiscount;
		private Label lblTotal;
		private ComboBox cbOrders;
		private GroupBox gbOrderInfor;
		private ComboBox cbCustomerName;
		private ComboBox cbEmployeeName;
		private TextBox txtAddress;
		private TextBox txtPhoneNumber;
		private TextBox txtOrderId;
		private TextBox txtOrderDate;
		private Label lblEmployeeName;
		private Label lblCustomerName;
		private Label lblAddress;
		private Label lblPhoneNumber;
		private Label lblOrderDate;
		private Label lblOrderId;
		private Label label3;
		private Label label2;
		private Button btnClose;
		private Button btnReload;
		private Button btnAdd;
		private Button btnDelete;
		private Button btnUpdate;
	}
}