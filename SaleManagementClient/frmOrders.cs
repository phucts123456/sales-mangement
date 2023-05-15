using SaleManagementDAL.DAO;
using SaleManagementDAL.Dtos;
using SaleManagementDAL.Models;
using SaleManagementDAL.Repository.Abstraction;


namespace SaleManagementClient
{
	public partial class frmOrders : Form
	{
		private IEnumerable<OrderDto> _order;
		private IEnumerable<OrderDetailDto> _ordersDetail;
		private IEnumerable<EmployeeDto> _employees;
		private IEnumerable<CustomerDto> _customer;
		private readonly IOrderRepository _orderRepository;
		private readonly IOrderDetailRepository _orderDetailRepository;
		private readonly IProductRepository _productRepository;
		private readonly ICustomerRepository _customerRepository;
		private readonly IEmployeeRepository _employeeRepository;
		public frmOrders(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository, IProductRepository productRepository, IEmployeeRepository employeeRepository, ICustomerRepository customerRepository)
		{
			InitializeComponent();
			_orderRepository = orderRepository;
			_orderDetailRepository = orderDetailRepository;
			_productRepository = productRepository;
			_employeeRepository = employeeRepository;
			_customerRepository = customerRepository;
		}

		private void onSelectedItem_Changed(object sender, EventArgs e)
		{

		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			OrderDto orderDto = _order.FirstOrDefault(x => x.OrderId == sbyte.Parse(cbOrders.SelectedValue.ToString()!))!;
			txtAddress.Text = orderDto.Customer.Address;
			txtPhoneNumber.Text = orderDto.Customer.PhoneNumber;
			txtOrderDate.Text = orderDto.OrderDate.ToString();
			txtOrderId.Text = orderDto.OrderId.ToString();
			_employees = _employeeRepository.GetAll();
			_customer = _customerRepository.GetAll();
			cbCustomerName.DataSource= _customer;
			cbCustomerName.DisplayMember = "CustomerName";
			cbCustomerName.ValueMember = "CustomerId";
			cbCustomerName.SelectedIndex = cbCustomerName.FindStringExact(_customer.FirstOrDefault(c => c.CustomerId == orderDto.CustomerId).CustomerName);
			cbEmployeeName.DataSource = _employees;
			cbEmployeeName.DisplayMember = "EmployeeName";
			cbEmployeeName.ValueMember = "EmployeeId";
			cbEmployeeName.SelectedIndex = cbEmployeeName.FindStringExact(_employees.FirstOrDefault(e => e.EmployeeId == orderDto.EmployeeId).EmployeeName);
			LoadDataGridView();
		}

		private void onDgv_Click(object sender, EventArgs e)
		{	
			cbProductName.DataSource = _productRepository.GetAll();
			cbProductName.DisplayMember = "ProductName";
			txtRetailPrice.Text = dgvOrders.CurrentRow.Cells["RetailPrice"].Value.ToString();
			txtDiscount.Text = dgvOrders.CurrentRow.Cells["Discount"].Value.ToString();
			txtQuantity.Text = dgvOrders.CurrentRow.Cells["Quantity"].Value.ToString();
			txtTotal.Text = dgvOrders.CurrentRow.Cells["Total"].Value.ToString();
		}
		private void onFrm_Load(object sender, EventArgs e)
		{
			comboBoxLoad();		
		}
		private void LoadDataGridView()
		{
			_ordersDetail = _orderDetailRepository.GetAll(sbyte.Parse(txtOrderId.Text));
			dgvOrders.DataSource = _ordersDetail;
			dgvOrders.Columns[0].HeaderText = "ProductName";
			dgvOrders.Columns[1].HeaderText = "Quantity";
			dgvOrders.Columns[2].HeaderText = "RetailPrice";
			dgvOrders.Columns[3].HeaderText = "Discount";
			dgvOrders.Columns[4].HeaderText = "Total";
			dgvOrders.Columns[0].Width = 200;
			dgvOrders.Columns[1].Width = 100;
			dgvOrders.Columns[2].Width = 100;
			dgvOrders.Columns[3].Width = 100;
			dgvOrders.Columns[4].Width = 100;
			dgvOrders.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
			dgvOrders.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
		}
		private void comboBoxLoad()
		{
			_order = _orderRepository.GetAll();
			cbOrders.DataSource = _order;
			cbOrders.DisplayMember = "OrderId";
			cbOrders.ValueMember = "OrderId";
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
		private OrderDto GetSelectedOrderDtoTxt()
		{
			DateTime orderDate;
			string address;
			string phoneNumber;
			sbyte employeeId;
			sbyte customerId;
			sbyte orderId;
			OrderDto orderDto = new OrderDto();
			orderDto.OrderId = !string.IsNullOrEmpty(txtOrderId.Text) ? sbyte.Parse(txtOrderId.Text) : default(sbyte);
			orderDto.OrderDate= !string.IsNullOrEmpty(txtOrderDate.Text) ? DateTime.Parse(txtOrderDate.Text) : default(DateTime);
			orderDto.CustomerId = !string.IsNullOrEmpty(cbCustomerName.SelectedValue.ToString()) ? sbyte.Parse(cbCustomerName.SelectedValue.ToString()!) : default(sbyte);
			orderDto.EmployeeId = !string.IsNullOrEmpty(cbEmployeeName.SelectedValue.ToString()) ? sbyte.Parse(cbEmployeeName.SelectedValue.ToString()!) : default(sbyte);
			orderDto.Customer = new CustomerDto();
			orderDto.Customer.Address = !string.IsNullOrEmpty(txtAddress.Text) ? txtAddress.Text : "";
			orderDto.Customer.PhoneNumber = !string.IsNullOrEmpty(txtPhoneNumber.Text) ? txtAddress.Text : "";
			return orderDto;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmCreateOrUpdateOrder frmOrder = new frmCreateOrUpdateOrder(_employeeRepository, _customerRepository, null,true);
			frmOrder.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			frmCreateOrUpdateOrder frmOrder = new frmCreateOrUpdateOrder(_employeeRepository, _customerRepository, GetSelectedOrderDtoTxt(),false);
			frmOrder.ShowDialog();
		}
	}
}
