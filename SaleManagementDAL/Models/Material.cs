using System;
using System.Collections.Generic;

namespace SaleManagementDAL.Models
{
    public partial class Material
    {
        public Material()
        {
            Products = new HashSet<Product>();
        }

        public sbyte MaterialId { get; set; }
        public string MaterialName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
