using System;
using System.Collections.Generic;

namespace SaleManagementDAL.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public sbyte EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
