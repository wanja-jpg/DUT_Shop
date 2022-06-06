using System;
using System.Collections.Generic;
using System.Text;
using static DUTShopLibrary.Enums;

namespace DUTShopLibrary.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }

        public EmployeePositions Position { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }
    }
}
