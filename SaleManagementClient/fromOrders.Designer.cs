namespace SaleManagementClient
{
	partial class fromOrders
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.scOrders = new System.Windows.Forms.SplitContainer();
			this.lblOrderList = new System.Windows.Forms.Label();
			this.gbOrder_Details = new System.Windows.Forms.GroupBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblRetailPrice = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.lblOrderDate = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.gbOrderInfor = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scOrders)).BeginInit();
			this.scOrders.Panel1.SuspendLayout();
			this.scOrders.Panel2.SuspendLayout();
			this.scOrders.SuspendLayout();
			this.gbOrder_Details.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gbOrderInfor.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox4);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 407);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(804, 44);
			this.panel1.TabIndex = 0;
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
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(367, 9);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(94, 29);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
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
			this.scOrders.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			// 
			// scOrders.Panel2
			// 
			this.scOrders.Panel2.Controls.Add(this.gbOrder_Details);
			this.scOrders.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
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
			// gbOrder_Details
			// 
			this.gbOrder_Details.Controls.Add(this.btnClose);
			this.gbOrder_Details.Controls.Add(this.btnReload);
			this.gbOrder_Details.Controls.Add(this.label3);
			this.gbOrder_Details.Controls.Add(this.btnAdd);
			this.gbOrder_Details.Controls.Add(this.btnDelete);
			this.gbOrder_Details.Controls.Add(this.btnUpdate);
			this.gbOrder_Details.Controls.Add(this.label2);
			this.gbOrder_Details.Controls.Add(this.comboBox3);
			this.gbOrder_Details.Controls.Add(this.dataGridView1);
			this.gbOrder_Details.Controls.Add(this.textBox14);
			this.gbOrder_Details.Controls.Add(this.textBox13);
			this.gbOrder_Details.Controls.Add(this.textBox12);
			this.gbOrder_Details.Controls.Add(this.textBox10);
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
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(539, 39);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(42, 20);
			this.lblTotal.TabIndex = 18;
			this.lblTotal.Text = "Total";
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
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(6, 51);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(65, 20);
			this.lblQuantity.TabIndex = 20;
			this.lblQuantity.Text = "Quantity";
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
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(3, 19);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(104, 20);
			this.lblProductName.TabIndex = 22;
			this.lblProductName.Text = "Product Name";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(113, 54);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(156, 27);
			this.textBox10.TabIndex = 24;
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(360, 19);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(156, 27);
			this.textBox12.TabIndex = 26;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(360, 52);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(156, 27);
			this.textBox13.TabIndex = 27;
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(584, 36);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(156, 27);
			this.textBox14.TabIndex = 28;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-1, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(804, 110);
			this.dataGridView1.TabIndex = 29;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(113, 20);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(156, 28);
			this.comboBox3.TabIndex = 30;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(584, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 31;
			this.label2.Text = "Total Price";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(678, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 20);
			this.label3.TabIndex = 32;
			this.label3.Text = "0";
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(92, 10);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(269, 28);
			this.comboBox4.TabIndex = 3;
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
			// lblOrderDate
			// 
			this.lblOrderDate.AutoSize = true;
			this.lblOrderDate.Location = new System.Drawing.Point(12, 55);
			this.lblOrderDate.Name = "lblOrderDate";
			this.lblOrderDate.Size = new System.Drawing.Size(83, 20);
			this.lblOrderDate.TabIndex = 1;
			this.lblOrderDate.Text = "Order Date";
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
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(417, 59);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(62, 20);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address";
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
			// lblEmployeeName
			// 
			this.lblEmployeeName.AutoSize = true;
			this.lblEmployeeName.Location = new System.Drawing.Point(11, 88);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(119, 20);
			this.lblEmployeeName.TabIndex = 7;
			this.lblEmployeeName.Text = "Employee Name";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(137, 52);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(242, 27);
			this.textBox2.TabIndex = 9;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(137, 20);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(242, 27);
			this.textBox3.TabIndex = 10;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(539, 85);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(242, 27);
			this.textBox6.TabIndex = 13;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(539, 52);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(242, 27);
			this.textBox7.TabIndex = 14;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(137, 84);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(242, 28);
			this.comboBox1.TabIndex = 16;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(538, 20);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(242, 28);
			this.comboBox2.TabIndex = 17;
			// 
			// gbOrderInfor
			// 
			this.gbOrderInfor.Controls.Add(this.comboBox2);
			this.gbOrderInfor.Controls.Add(this.comboBox1);
			this.gbOrderInfor.Controls.Add(this.textBox7);
			this.gbOrderInfor.Controls.Add(this.textBox6);
			this.gbOrderInfor.Controls.Add(this.textBox3);
			this.gbOrderInfor.Controls.Add(this.textBox2);
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
			// 
			// fromOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 450);
			this.Controls.Add(this.scOrders);
			this.Controls.Add(this.panel1);
			this.Name = "fromOrders";
			this.Text = "fromOrders";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.scOrders.Panel1.ResumeLayout(false);
			this.scOrders.Panel1.PerformLayout();
			this.scOrders.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scOrders)).EndInit();
			this.scOrders.ResumeLayout(false);
			this.gbOrder_Details.ResumeLayout(false);
			this.gbOrder_Details.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gbOrderInfor.ResumeLayout(false);
			this.gbOrderInfor.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Button btnSearch;
		private Label label1;
		private SplitContainer scOrders;
		private Label lblOrderList;
		private GroupBox gbOrder_Details;
		private ComboBox comboBox3;
		private DataGridView dataGridView1;
		private TextBox textBox14;
		private TextBox textBox13;
		private TextBox textBox12;
		private TextBox textBox10;
		private Label lblProductName;
		private Label lblRetailPrice;
		private Label lblQuantity;
		private Label lblDiscount;
		private Label lblTotal;
		private ComboBox comboBox4;
		private GroupBox gbOrderInfor;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
		private TextBox textBox7;
		private TextBox textBox6;
		private TextBox textBox3;
		private TextBox textBox2;
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