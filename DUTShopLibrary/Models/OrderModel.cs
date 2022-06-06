using System;
using System.Collections.Generic;
using System.Text;

namespace DUTShopLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public CustomerModel Customer { get; set; }
        public EmployeeModel Employee { get; set; }

        public List<ProductModel> Products { get; set; }

        public decimal TotalPrice { get; set; }

        public float Discount { get; set; }

        public string Address { get; set; }

        public bool IsComplete { get; set; }
    }
}
