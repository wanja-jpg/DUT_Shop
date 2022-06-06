using System;
using System.Collections.Generic;
using System.Text;

namespace DUTShopLibrary.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName {
            get 
            {
                return $"{FirstName} {LastName}";
            }
        }

        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }
    }
}
